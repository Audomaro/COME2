using COME.Clases;
using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COME.Clientes
{
    public partial class FrmCliente : XtraForm
    {
        Accion _accion = Accion.Registrar;
        Cliente Datos_Cliente;

        public FrmCliente(Accion accion, ref Cliente datosCliente)
        {
            InitializeComponent();
            this._accion = accion;
            this.Datos_Cliente = datosCliente;
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (this.TxtClave.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Falta la clave del Cliente.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.TxtClave.Focus();
                return;
            }

            string SP = string.Empty;
            bool hecho = false;
            List<FbParameter> Parametros = new List<FbParameter>();

            this.Datos_Cliente.Clave = this.TxtClave.Text.Trim();
            this.Datos_Cliente.Descripcion = this.TxtDescripcion.Text.Trim();

            switch (this._accion)
            {
                case Accion.Registrar: 
                    SP = "SP_CLIENTES_INS"; 
                    break;
                case Accion.Modificar:
                    SP = "SP_CLIENTES_MOD";
                    break;
                case Accion.Eliminar:
                    SP = "SP_CLIENTES_DEL";
                    break;
            }

            if (this._accion == Accion.Modificar || this._accion == Accion.Eliminar)
            { 
                Parametros.Add(new FbParameter() { ParameterName = "@ID", FbDbType = FbDbType.Integer, Value = this.Datos_Cliente.ID });
            }

            if (this._accion == Accion.Registrar || this._accion == Accion.Modificar)
            { 
                Parametros.Add(new FbParameter() { ParameterName = "@CLAVE", FbDbType = FbDbType.VarChar, Size = 50, Value = this.Datos_Cliente.Clave });
                Parametros.Add(new FbParameter() { ParameterName = "@DESCRIPCION", FbDbType = FbDbType.VarChar, Size = 50, Value = this.Datos_Cliente.Descripcion });
            }

            hecho = BaseDeDatos.EjecutarSP(SP, Parametros, Modulo.Clientes, this._accion);

            if (hecho)
            {
                if(this._accion == Accion.Registrar)
                {
                    this.Datos_Cliente.ID = Convert.ToInt32(BaseDeDatos.TraeCampoSP("SP_CLIENTES_ELT"));                    
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                this.TxtClave.Focus();
            }
            this.Datos_Cliente.EjecutarAccion = hecho;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Datos_Cliente.EjecutarAccion = false;
            this.Close();
            this.Dispose();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Text = this._accion.ToString();
            if(this._accion != Accion.Registrar)
            {
                this.TxtClave.Text = this.Datos_Cliente.Clave;
                this.TxtDescripcion.Text = this.Datos_Cliente.Descripcion;
            }

            if (this._accion == Accion.Consultar || this._accion == Accion.Eliminar)
            {
                this.TxtClave.Properties.ReadOnly = true;
                this.TxtDescripcion.Properties.ReadOnly = true;
                this.BtnGuardar.Visible = this._accion == Accion.Consultar ? false : true;
                this.BtnGuardar.Text = "Eliminar";
                this.BtnCancelar.Text = "Cerrar";
            }
        }
    }
}