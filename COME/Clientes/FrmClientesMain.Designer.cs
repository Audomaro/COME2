namespace COME.Clientes
{
    partial class FrmClientesMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesMain));
            this.RbClientes = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarBtnRegistrar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnXLS = new DevExpress.XtraBars.BarButtonItem();
            this.BarSubItemImprimir = new DevExpress.XtraBars.BarSubItem();
            this.BarBtnItmVistaPreliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnItmImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BarStaItmClientes = new DevExpress.XtraBars.BarEditItem();
            this.BarStaItmTxtClientes = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RpClientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgClientesComun = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgInforme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgClientesOtros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RsbClientes = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GClientes = new DevExpress.XtraGrid.GridControl();
            this.GvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.RbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarStaItmTxtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // RbClientes
            // 
            this.RbClientes.AllowMinimizeRibbon = false;
            this.RbClientes.ExpandCollapseItem.Id = 0;
            this.RbClientes.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RbClientes.ExpandCollapseItem,
            this.BarBtnRegistrar,
            this.BarBtnModificar,
            this.BarBtnConsultar,
            this.BarBtnCerrar,
            this.BarBtnEliminar,
            this.BarBtnPDF,
            this.BarBtnXLS,
            this.BarSubItemImprimir,
            this.BarBtnItmVistaPreliminar,
            this.BarBtnItmImprimir,
            this.BarStaItmClientes});
            this.RbClientes.Location = new System.Drawing.Point(0, 0);
            this.RbClientes.MaxItemId = 42;
            this.RbClientes.Name = "RbClientes";
            this.RbClientes.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpClientes});
            this.RbClientes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.BarStaItmTxtClientes});
            this.RbClientes.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RbClientes.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RbClientes.ShowToolbarCustomizeItem = false;
            this.RbClientes.Size = new System.Drawing.Size(798, 144);
            this.RbClientes.StatusBar = this.RsbClientes;
            this.RbClientes.Toolbar.ShowCustomizeItem = false;
            // 
            // BarBtnRegistrar
            // 
            this.BarBtnRegistrar.Caption = "Registrar";
            this.BarBtnRegistrar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnRegistrar.Glyph")));
            this.BarBtnRegistrar.Id = 1;
            this.BarBtnRegistrar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.BarBtnRegistrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnRegistrar.LargeGlyph")));
            this.BarBtnRegistrar.Name = "BarBtnRegistrar";
            this.BarBtnRegistrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnRegistrar_ItemClick);
            // 
            // BarBtnModificar
            // 
            this.BarBtnModificar.Caption = "Modificar";
            this.BarBtnModificar.Enabled = false;
            this.BarBtnModificar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnModificar.Glyph")));
            this.BarBtnModificar.Id = 3;
            this.BarBtnModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.BarBtnModificar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnModificar.LargeGlyph")));
            this.BarBtnModificar.Name = "BarBtnModificar";
            this.BarBtnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnModificar_ItemClick);
            // 
            // BarBtnConsultar
            // 
            this.BarBtnConsultar.Caption = "Consultar";
            this.BarBtnConsultar.Enabled = false;
            this.BarBtnConsultar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnConsultar.Glyph")));
            this.BarBtnConsultar.Id = 4;
            this.BarBtnConsultar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.BarBtnConsultar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnConsultar.LargeGlyph")));
            this.BarBtnConsultar.Name = "BarBtnConsultar";
            this.BarBtnConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnConsultar_ItemClick);
            // 
            // BarBtnCerrar
            // 
            this.BarBtnCerrar.Caption = "Cerrar";
            this.BarBtnCerrar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BarBtnCerrar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.Glyph")));
            this.BarBtnCerrar.Id = 8;
            this.BarBtnCerrar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.BarBtnCerrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.LargeGlyph")));
            this.BarBtnCerrar.Name = "BarBtnCerrar";
            this.BarBtnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnCerrar_ItemClick);
            // 
            // BarBtnEliminar
            // 
            this.BarBtnEliminar.Caption = "Eliminar";
            this.BarBtnEliminar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BarBtnEliminar.Enabled = false;
            this.BarBtnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnEliminar.Glyph")));
            this.BarBtnEliminar.Id = 13;
            this.BarBtnEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.BarBtnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnEliminar.LargeGlyph")));
            this.BarBtnEliminar.Name = "BarBtnEliminar";
            this.BarBtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnEliminar_ItemClick);
            // 
            // BarBtnPDF
            // 
            this.BarBtnPDF.Caption = "Exportar a PDF";
            this.BarBtnPDF.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BarBtnPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnPDF.Glyph")));
            this.BarBtnPDF.Id = 15;
            this.BarBtnPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnPDF.LargeGlyph")));
            this.BarBtnPDF.Name = "BarBtnPDF";
            this.BarBtnPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnPDF_ItemClick);
            // 
            // BarBtnXLS
            // 
            this.BarBtnXLS.Caption = "Exportar a Excel";
            this.BarBtnXLS.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BarBtnXLS.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnXLS.Glyph")));
            this.BarBtnXLS.Id = 16;
            this.BarBtnXLS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnXLS.LargeGlyph")));
            this.BarBtnXLS.Name = "BarBtnXLS";
            this.BarBtnXLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnXLS_ItemClick);
            // 
            // BarSubItemImprimir
            // 
            this.BarSubItemImprimir.Caption = "Imprimir";
            this.BarSubItemImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("BarSubItemImprimir.Glyph")));
            this.BarSubItemImprimir.Id = 31;
            this.BarSubItemImprimir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarSubItemImprimir.LargeGlyph")));
            this.BarSubItemImprimir.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarBtnItmVistaPreliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarBtnItmImprimir)});
            this.BarSubItemImprimir.Name = "BarSubItemImprimir";
            // 
            // BarBtnItmVistaPreliminar
            // 
            this.BarBtnItmVistaPreliminar.Caption = "Vista preliminar";
            this.BarBtnItmVistaPreliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnItmVistaPreliminar.Glyph")));
            this.BarBtnItmVistaPreliminar.Id = 35;
            this.BarBtnItmVistaPreliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnItmVistaPreliminar.LargeGlyph")));
            this.BarBtnItmVistaPreliminar.Name = "BarBtnItmVistaPreliminar";
            this.BarBtnItmVistaPreliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnItmVistaPreliminar_ItemClick);
            // 
            // BarBtnItmImprimir
            // 
            this.BarBtnItmImprimir.Caption = "Imprimir";
            this.BarBtnItmImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnItmImprimir.Glyph")));
            this.BarBtnItmImprimir.Id = 36;
            this.BarBtnItmImprimir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnItmImprimir.LargeGlyph")));
            this.BarBtnItmImprimir.Name = "BarBtnItmImprimir";
            this.BarBtnItmImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnItmImprimir_ItemClick);
            // 
            // BarStaItmClientes
            // 
            this.BarStaItmClientes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarStaItmClientes.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.BarStaItmClientes.Caption = "N° Clientes:";
            this.BarStaItmClientes.Edit = this.BarStaItmTxtClientes;
            this.BarStaItmClientes.EditValue = "0";
            this.BarStaItmClientes.Glyph = ((System.Drawing.Image)(resources.GetObject("BarStaItmClientes.Glyph")));
            this.BarStaItmClientes.Id = 41;
            this.BarStaItmClientes.Name = "BarStaItmClientes";
            this.BarStaItmClientes.Width = 100;
            // 
            // BarStaItmTxtClientes
            // 
            this.BarStaItmTxtClientes.AllowMouseWheel = false;
            this.BarStaItmTxtClientes.AutoHeight = false;
            this.BarStaItmTxtClientes.Name = "BarStaItmTxtClientes";
            this.BarStaItmTxtClientes.ReadOnly = true;
            // 
            // RpClientes
            // 
            this.RpClientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgClientesComun,
            this.RpgInforme,
            this.RpgClientesOtros});
            this.RpClientes.Name = "RpClientes";
            this.RpClientes.Text = "Clientes";
            // 
            // RpgClientesComun
            // 
            this.RpgClientesComun.ItemLinks.Add(this.BarBtnRegistrar);
            this.RpgClientesComun.ItemLinks.Add(this.BarBtnModificar);
            this.RpgClientesComun.ItemLinks.Add(this.BarBtnConsultar);
            this.RpgClientesComun.ItemLinks.Add(this.BarBtnEliminar);
            this.RpgClientesComun.Name = "RpgClientesComun";
            this.RpgClientesComun.ShowCaptionButton = false;
            this.RpgClientesComun.Text = "Común";
            // 
            // RpgInforme
            // 
            this.RpgInforme.ItemLinks.Add(this.BarSubItemImprimir);
            this.RpgInforme.ItemLinks.Add(this.BarBtnPDF);
            this.RpgInforme.ItemLinks.Add(this.BarBtnXLS);
            this.RpgInforme.Name = "RpgInforme";
            this.RpgInforme.ShowCaptionButton = false;
            this.RpgInforme.Text = "Informe";
            // 
            // RpgClientesOtros
            // 
            this.RpgClientesOtros.ItemLinks.Add(this.BarBtnCerrar);
            this.RpgClientesOtros.Name = "RpgClientesOtros";
            this.RpgClientesOtros.ShowCaptionButton = false;
            this.RpgClientesOtros.Text = "Otros";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // RsbClientes
            // 
            this.RsbClientes.ItemLinks.Add(this.BarStaItmClientes, true);
            this.RsbClientes.Location = new System.Drawing.Point(0, 447);
            this.RsbClientes.Name = "RsbClientes";
            this.RsbClientes.Ribbon = this.RbClientes;
            this.RsbClientes.Size = new System.Drawing.Size(798, 31);
            // 
            // GClientes
            // 
            this.GClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.GClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GClientes.Location = new System.Drawing.Point(0, 144);
            this.GClientes.MainView = this.GvClientes;
            this.GClientes.MenuManager = this.RbClientes;
            this.GClientes.Name = "GClientes";
            this.GClientes.Size = new System.Drawing.Size(798, 334);
            this.GClientes.TabIndex = 1;
            this.GClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvClientes});
            // 
            // GvClientes
            // 
            this.GvClientes.GridControl = this.GClientes;
            this.GvClientes.Name = "GvClientes";
            this.GvClientes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GvClientes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GvClientes.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.GvClientes.OptionsBehavior.Editable = false;
            this.GvClientes.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.GvClientes.OptionsCustomization.AllowColumnResizing = false;
            this.GvClientes.OptionsCustomization.AllowQuickHideColumns = false;
            this.GvClientes.OptionsDetail.EnableMasterViewMode = false;
            this.GvClientes.OptionsFind.AlwaysVisible = true;
            this.GvClientes.OptionsFind.FindNullPrompt = "Dato a buscar...";
            this.GvClientes.OptionsFind.SearchInPreview = true;
            this.GvClientes.OptionsFind.ShowCloseButton = false;
            this.GvClientes.OptionsFind.ShowFindButton = false;
            this.GvClientes.OptionsNavigation.AutoFocusNewRow = true;
            this.GvClientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GvClientes.OptionsView.ShowFooter = true;
            this.GvClientes.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.GvClientes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvClientes_FocusedRowChanged);
            this.GvClientes.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.GvClientes_RowDeleted);
            this.GvClientes.RowCountChanged += new System.EventHandler(this.GvClientes_RowCountChanged);
            // 
            // FrmClientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.RsbClientes);
            this.Controls.Add(this.GClientes);
            this.Controls.Add(this.RbClientes);
            this.Name = "FrmClientesMain";
            this.Ribbon = this.RbClientes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.RsbClientes;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientesMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarStaItmTxtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RbClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgClientesComun;
        private DevExpress.XtraBars.BarButtonItem BarBtnRegistrar;
        private DevExpress.XtraBars.BarButtonItem BarBtnModificar;
        private DevExpress.XtraBars.BarButtonItem BarBtnConsultar;
        private DevExpress.XtraGrid.GridControl GClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView GvClientes;
        private DevExpress.XtraBars.BarButtonItem BarBtnCerrar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgClientesOtros;
        private DevExpress.XtraBars.BarButtonItem BarBtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BarBtnPDF;
        private DevExpress.XtraBars.BarButtonItem BarBtnXLS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgInforme;
        private DevExpress.XtraBars.BarSubItem BarSubItemImprimir;
        private DevExpress.XtraBars.BarButtonItem BarBtnItmVistaPreliminar;
        private DevExpress.XtraBars.BarButtonItem BarBtnItmImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RsbClientes;
        private DevExpress.XtraBars.BarEditItem BarStaItmClientes;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit BarStaItmTxtClientes;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}