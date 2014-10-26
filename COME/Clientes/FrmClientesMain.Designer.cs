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
            this.Rb = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarBtnRegistrar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnXLS = new DevExpress.XtraBars.BarButtonItem();
            this.BarSubItemImprimir = new DevExpress.XtraBars.BarSubItem();
            this.BarBtnItmVistaPreliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnItmImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BarStaItmConteo = new DevExpress.XtraBars.BarEditItem();
            this.BarStaItmTxtConteo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BarBtnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.Rp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgComun = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgInforme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgOtros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RsbClientes = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.Gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarStaItmTxtConteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).BeginInit();
            this.SuspendLayout();
            // 
            // Rb
            // 
            this.Rb.AllowMinimizeRibbon = false;
            this.Rb.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.Rb.ExpandCollapseItem.Id = 0;
            this.Rb.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Rb.ExpandCollapseItem,
            this.BarBtnRegistrar,
            this.BarBtnModificar,
            this.BarBtnConsultar,
            this.BarBtnEliminar,
            this.BarBtnPDF,
            this.BarBtnXLS,
            this.BarSubItemImprimir,
            this.BarBtnItmVistaPreliminar,
            this.BarBtnItmImprimir,
            this.BarStaItmConteo,
            this.BarBtnRefrescar,
            this.BarBtnCerrar});
            this.Rb.Location = new System.Drawing.Point(0, 0);
            this.Rb.MaxItemId = 44;
            this.Rb.Name = "Rb";
            this.Rb.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Rp});
            this.Rb.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BarStaItmTxtConteo});
            this.Rb.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.Rb.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.Rb.ShowToolbarCustomizeItem = false;
            this.Rb.Size = new System.Drawing.Size(798, 144);
            this.Rb.StatusBar = this.RsbClientes;
            this.Rb.Toolbar.ShowCustomizeItem = false;
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
            // BarBtnEliminar
            // 
            this.BarBtnEliminar.Caption = "Eliminar";
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
            this.BarBtnPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnPDF.Glyph")));
            this.BarBtnPDF.Id = 15;
            this.BarBtnPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnPDF.LargeGlyph")));
            this.BarBtnPDF.Name = "BarBtnPDF";
            this.BarBtnPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnPDF_ItemClick);
            // 
            // BarBtnXLS
            // 
            this.BarBtnXLS.Caption = "Exportar a Excel";
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
            // BarStaItmConteo
            // 
            this.BarStaItmConteo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarStaItmConteo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.BarStaItmConteo.Caption = "N° Clientes:";
            this.BarStaItmConteo.Edit = this.BarStaItmTxtConteo;
            this.BarStaItmConteo.EditValue = "0";
            this.BarStaItmConteo.Glyph = ((System.Drawing.Image)(resources.GetObject("BarStaItmConteo.Glyph")));
            this.BarStaItmConteo.Id = 41;
            this.BarStaItmConteo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarStaItmConteo.LargeGlyph")));
            this.BarStaItmConteo.Name = "BarStaItmConteo";
            this.BarStaItmConteo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.BarStaItmConteo.Width = 100;
            // 
            // BarStaItmTxtConteo
            // 
            this.BarStaItmTxtConteo.AllowMouseWheel = false;
            this.BarStaItmTxtConteo.AutoHeight = false;
            this.BarStaItmTxtConteo.Name = "BarStaItmTxtConteo";
            this.BarStaItmTxtConteo.ReadOnly = true;
            // 
            // BarBtnRefrescar
            // 
            this.BarBtnRefrescar.Caption = "Refrescar";
            this.BarBtnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnRefrescar.Glyph")));
            this.BarBtnRefrescar.Id = 42;
            this.BarBtnRefrescar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.BarBtnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnRefrescar.LargeGlyph")));
            this.BarBtnRefrescar.Name = "BarBtnRefrescar";
            // 
            // BarBtnCerrar
            // 
            this.BarBtnCerrar.Caption = "Cerrar";
            this.BarBtnCerrar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.Glyph")));
            this.BarBtnCerrar.Id = 43;
            this.BarBtnCerrar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.BarBtnCerrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.LargeGlyph")));
            this.BarBtnCerrar.Name = "BarBtnCerrar";
            this.BarBtnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnCerrar_ItemClick);
            // 
            // Rp
            // 
            this.Rp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgComun,
            this.RpgInforme,
            this.RpgOtros});
            this.Rp.Name = "Rp";
            this.Rp.Text = "Clientes";
            // 
            // RpgComun
            // 
            this.RpgComun.ItemLinks.Add(this.BarBtnRegistrar);
            this.RpgComun.ItemLinks.Add(this.BarBtnModificar);
            this.RpgComun.ItemLinks.Add(this.BarBtnConsultar);
            this.RpgComun.ItemLinks.Add(this.BarBtnEliminar);
            this.RpgComun.ItemLinks.Add(this.BarBtnRefrescar);
            this.RpgComun.Name = "RpgComun";
            this.RpgComun.ShowCaptionButton = false;
            this.RpgComun.Text = "Común";
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
            // RpgOtros
            // 
            this.RpgOtros.ItemLinks.Add(this.BarBtnCerrar);
            this.RpgOtros.Name = "RpgOtros";
            this.RpgOtros.ShowCaptionButton = false;
            this.RpgOtros.Text = "Otros";
            // 
            // RsbClientes
            // 
            this.RsbClientes.ItemLinks.Add(this.BarStaItmConteo, true);
            this.RsbClientes.Location = new System.Drawing.Point(0, 447);
            this.RsbClientes.Name = "RsbClientes";
            this.RsbClientes.Ribbon = this.Rb;
            this.RsbClientes.Size = new System.Drawing.Size(798, 31);
            // 
            // Grid
            // 
            this.Grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 144);
            this.Grid.MainView = this.Gv;
            this.Grid.MenuManager = this.Rb;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(798, 334);
            this.Grid.TabIndex = 1;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv});
            // 
            // Gv
            // 
            this.Gv.GridControl = this.Grid;
            this.Gv.Name = "Gv";
            this.Gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.Gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.Gv.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.Gv.OptionsBehavior.Editable = false;
            this.Gv.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.Gv.OptionsCustomization.AllowColumnResizing = false;
            this.Gv.OptionsCustomization.AllowQuickHideColumns = false;
            this.Gv.OptionsDetail.EnableMasterViewMode = false;
            this.Gv.OptionsFind.AlwaysVisible = true;
            this.Gv.OptionsFind.FindNullPrompt = "Dato a buscar...";
            this.Gv.OptionsFind.SearchInPreview = true;
            this.Gv.OptionsFind.ShowCloseButton = false;
            this.Gv.OptionsFind.ShowFindButton = false;
            this.Gv.OptionsNavigation.AutoFocusNewRow = true;
            this.Gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.Gv.OptionsView.ShowFooter = true;
            this.Gv.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.Gv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.Gv_FocusedRowChanged);
            this.Gv.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.Gv_RowDeleted);
            this.Gv.RowCountChanged += new System.EventHandler(this.Gv_RowCountChanged);
            // 
            // FrmClientesMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.RsbClientes);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Rb);
            this.Name = "FrmClientesMain";
            this.Ribbon = this.Rb;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.RsbClientes;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Rb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarStaItmTxtConteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Rb;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgComun;
        private DevExpress.XtraBars.BarButtonItem BarBtnRegistrar;
        private DevExpress.XtraBars.BarButtonItem BarBtnModificar;
        private DevExpress.XtraBars.BarButtonItem BarBtnConsultar;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgOtros;
        private DevExpress.XtraBars.BarButtonItem BarBtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BarBtnPDF;
        private DevExpress.XtraBars.BarButtonItem BarBtnXLS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgInforme;
        private DevExpress.XtraBars.BarSubItem BarSubItemImprimir;
        private DevExpress.XtraBars.BarButtonItem BarBtnItmVistaPreliminar;
        private DevExpress.XtraBars.BarButtonItem BarBtnItmImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RsbClientes;
        private DevExpress.XtraBars.BarEditItem BarStaItmConteo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit BarStaItmTxtConteo;
        private DevExpress.XtraBars.BarButtonItem BarBtnRefrescar;
        private DevExpress.XtraBars.BarButtonItem BarBtnCerrar;
    }
}