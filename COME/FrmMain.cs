using COME.Clases;
using COME.Clientes;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COME
{
    public partial class FrmMain : RibbonForm
    {
        List<RibbonForm> ListaForm = new List<RibbonForm>();
        FrmClientesMain Clientes;

        public FrmMain()
        {
            InitializeComponent(); 
            SkinHelper.InitSkinGallery(this.SRG);
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Skin_StyleChanged);
        }

        private void BarBtnClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Clientes == null || Clientes.IsDisposed == true)
            {
                Clientes = new FrmClientesMain()
                {
                    ShowInTaskbar = false,
                    MdiParent = this,
                    ShowIcon = false
                };
            }

            this.Ribbon.SelectedPage = Clientes.Ribbon.Pages[0];
            Clientes.WindowState = FormWindowState.Maximized;
            Clientes.Show();
        }

        private void BarBtnCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void Skin_StyleChanged(object sender, EventArgs e)
        {
            Configuracion.SkinSeleccionado = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
    }
}