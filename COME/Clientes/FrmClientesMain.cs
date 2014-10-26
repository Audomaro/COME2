using COME.Clases;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace COME.Clientes
{
    public partial class FrmClientesMain : RibbonForm
    {
        #region Variables
        /// <summary>
        /// Objeto Cliente, los datos de este se modificar por referencia 'ref'.
        /// </summary>
        Cliente Datos_Cliente = new Cliente();
        /// <summary>
        /// Renglon seleccionado o enfocado.
        /// </summary>
        int _rowSeleccionado = -1;
        /// <summary>
        /// Cuadro para guardar archicos.
        /// </summary>
        SaveFileDialog _fichero = new SaveFileDialog();
        /// <summary>
        /// Acción
        /// </summary>
        Accion _accion = Accion.Ninguna;
        #endregion

        #region Procedimientos de Form
        public FrmClientesMain()
        {
            InitializeComponent();
        }

        private void FrmClientesMain_Load(object sender, EventArgs e)
        {
            // Carga la lista de los Clientes desde la Base de Datos.
            this.Grid.DataSource = BaseDeDatos.CargaDataTable("SELECT * FROM VW_CLIENTES");
            
            // Cuenta la cantidad de Clientes registrados.
            this.BarStaItmConteo.EditValue = BaseDeDatos.TraeCampoSP("SP_CLIENTES_CNT");
            this._rowSeleccionado = this.Gv.RowCount > 0 ? 0 : -1;

            // Directorio inicial
            this._fichero.InitialDirectory = @"Desktop";
        }
                
        private void BarBtnRegistrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Crea un Form Cliente para registrar un nuevo Cliente.
            FrmCliente Registrar = new FrmCliente(Accion.Registrar, ref this.Datos_Cliente);
            Registrar.ShowDialog();
            
            // Si el store procedure correspondiente se ejecuto sin problemas 'EjecutarAccion' sera true.
            if (this.Datos_Cliente.EjecutarAccion)
            {
                // Agrega un nuevo renglón
                this._accion = Accion.Registrar; // Evita que se ejecute el evento  'FocusedRowChanged'
                this.Gv.AddNewRow();
                int newRow = this.Gv.FocusedRowHandle;
                this.Gv.SetRowCellValue(newRow, "#", this.Datos_Cliente.ID);
                this.Gv.SetRowCellValue(newRow, "Clave", this.Datos_Cliente.Clave);
                this.Gv.SetRowCellValue(newRow, "Descripcion", this.Datos_Cliente.Descripcion);
                this.Gv.FocusedRowHandle = this.Gv.RowCount - 1;
                this._accion = Accion.Ninguna;
            }
        }

        private void BarBtnModificar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Crea un Form Cliente para modificar el Cliente seleccionado.
            FrmCliente Modificar = new FrmCliente(Accion.Modificar, ref this.Datos_Cliente);
            Modificar.ShowDialog();

            // Si el store procedure correspondiente se ejecuto sin problemas 'EjecutarAccion' sera true.
            if (this.Datos_Cliente.EjecutarAccion)
            {
                // Modificar el contenido del renglón seleccionado con los datos del objeto Cliente.
                this.Gv.SetRowCellValue(this._rowSeleccionado, "Clave", this.Datos_Cliente.Clave);
                this.Gv.SetRowCellValue(this._rowSeleccionado, "Descripcion", this.Datos_Cliente.Descripcion);
            }
        }
                
        private void BarBtnConsultar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Crea un Form Cliente para consultar los datos del Cliente seleccionado.
            FrmCliente Consultar = new FrmCliente(Accion.Consultar, ref this.Datos_Cliente);
            Consultar.ShowDialog();
        }

        private void BarBtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Crea un Form Cliente para eliminar los datos del Cliente seleccionado.
            FrmCliente Eliminar = new FrmCliente(Accion.Eliminar, ref this.Datos_Cliente);
            Eliminar.ShowDialog();
            
            // Si el store procedure correspondiente se ejecuto sin problemas 'EjecutarAccion' sera true.
            if (this.Datos_Cliente.EjecutarAccion)
            {
                // Elimina visualmente el renglón seleccionado.
                this.Gv.DeleteRow(this._rowSeleccionado);
            }
        }
        
        private void BarBtnItmVistaPreliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!this.Grid.IsPrintingAvailable)
            {
                XtraMessageBox.Show("No se puede impremir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Grid.ShowPrintPreview();
        }

        private void BarBtnItmImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!this.Grid.IsPrintingAvailable)
            {
                XtraMessageBox.Show("No se puede impremir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Grid.PrintDialog();
        }

        private void BarBtnXLS_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._fichero.Filter = "Excel 2003 (*.xls)|*.xls|Excel 2007-2013 (*.xlsx)|*.xlsx";

            if (this._fichero.ShowDialog() == DialogResult.OK)
            {
                switch (this._fichero.FilterIndex)
                {
                    case 1: this.Gv.ExportToXls(this._fichero.FileName); break;
                    case 2: this.Gv.ExportToXlsx(this._fichero.FileName); break;
                }
            }
        }

        private void BarBtnPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._fichero.Filter = "Portable Document Format (*.pdf)|*.pdf";
            if (this._fichero.ShowDialog() == DialogResult.OK)
            {
                this.Gv.ExportToPdf(this._fichero.FileName);
            }
        }

        private void BarBtnCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Gv_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (this._accion != Accion.Registrar)
            {
                // Deshabilita los controles para manipular los datos del Cliente.
                this.HabilitarBotones(false);

                this._rowSeleccionado = e.FocusedRowHandle;

                // Si evalue si existen renglones y despues si el que se encuentra enfocado es mayor a -1.
                if (this._rowSeleccionado > -1)
                {
                    // Si el renglón no es negativo o es un nuevo renglónse habilitan los controles para manipular los datos del Cliente.
                    HabilitarBotones(true);
                    this.AsignarDatos(this._rowSeleccionado);
                }
            }
        }

        private void Gv_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            if (this._rowSeleccionado <= this.Gv.RowCount - 1) 
            {
                // Asigna los datos del renglón al Objeto Cliente si este se encuentra en medio de la lista,
                // ya que a eliminar no se sucede el evento 'FocusedRowChanged'
                this.AsignarDatos(this._rowSeleccionado);
            } 
        }

        private void Gv_RowCountChanged(object sender, EventArgs e)
        {
            // Actualiza la cantidad de Clientes registrados.
            this.BarStaItmConteo.EditValue = BaseDeDatos.TraeCampoSP("SP_CLIENTES_CNT");
        }
        #endregion

        #region Procedimientos Propios
        /// <summary>
        /// Pasa los datos del reglón enfocado al objeto Cliente.
        /// </summary>
        private void AsignarDatos(int row = -1)
        {
            int tempRow = row;

            this.Datos_Cliente.ID = -1;
            this.Datos_Cliente.Clave = string.Empty;
            this.Datos_Cliente.Descripcion = string.Empty;

            if (tempRow > -1)
            {
                // Si existe renglón enfocado se pasan sus datos al objeto Cliente.
                this.Datos_Cliente.ID = Convert.ToInt32(this.Gv.GetDataRow(tempRow)["#"].ToString());
                this.Datos_Cliente.Clave = this.Gv.GetDataRow(tempRow)["Clave"].ToString();
                this.Datos_Cliente.Descripcion = this.Gv.GetDataRow(tempRow)["Descripcion"].ToString();
            }
        }

        /// <summary>
        /// Habilita o Deshabilita los controles usados para manipular los datos del Cliente.
        /// </summary>
        /// <param name="habilitar">True => Habilita los controles; False => Deshabilita los controles </param>
        private void HabilitarBotones(bool habilitar)
        {
            this.BarBtnModificar.Enabled = habilitar;
            this.BarBtnEliminar.Enabled = habilitar;
            this.BarBtnConsultar.Enabled = habilitar;
        }
        #endregion

    }
}