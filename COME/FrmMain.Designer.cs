namespace COME
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.RbMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarBtnMercancias = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.SRG = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.BarBtnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.BarMdiChildrenList = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.rpCatalogos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgCatalogos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgConfig = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageSkins = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.RbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // RbMain
            // 
            this.RbMain.AllowMinimizeRibbon = false;
            this.RbMain.ExpandCollapseItem.Id = 0;
            this.RbMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RbMain.ExpandCollapseItem,
            this.BarBtnMercancias,
            this.BarBtnClientes,
            this.SRG,
            this.BarBtnCerrar,
            this.BarMdiChildrenList});
            this.RbMain.Location = new System.Drawing.Point(0, 0);
            this.RbMain.MaxItemId = 1;
            this.RbMain.Name = "RbMain";
            this.RbMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCatalogos});
            this.RbMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RbMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RbMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RbMain.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.True;
            this.RbMain.ShowToolbarCustomizeItem = false;
            this.RbMain.Size = new System.Drawing.Size(761, 144);
            this.RbMain.StatusBar = this.ribbonStatusBar;
            this.RbMain.Toolbar.ShowCustomizeItem = false;
            // 
            // BarBtnMercancias
            // 
            this.BarBtnMercancias.Caption = "Mercancias";
            this.BarBtnMercancias.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnMercancias.Glyph")));
            this.BarBtnMercancias.Id = 1;
            this.BarBtnMercancias.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.BarBtnMercancias.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnMercancias.LargeGlyph")));
            this.BarBtnMercancias.Name = "BarBtnMercancias";
            this.BarBtnMercancias.ShortcutKeyDisplayString = "F3 para ver el catálogo de Mercancías.";
            // 
            // BarBtnClientes
            // 
            this.BarBtnClientes.Caption = "Clientes";
            this.BarBtnClientes.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnClientes.Glyph")));
            this.BarBtnClientes.Id = 2;
            this.BarBtnClientes.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.BarBtnClientes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnClientes.LargeGlyph")));
            this.BarBtnClientes.Name = "BarBtnClientes";
            this.BarBtnClientes.ShortcutKeyDisplayString = "F3 para ver el catálogo de Clientes.";
            this.BarBtnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnClientes_ItemClick);
            // 
            // SRG
            // 
            this.SRG.Caption = "Skin";
            this.SRG.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.SRG.Id = 4;
            this.SRG.Name = "SRG";
            // 
            // BarBtnCerrar
            // 
            this.BarBtnCerrar.Caption = "Cerrar";
            this.BarBtnCerrar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BarBtnCerrar.Glyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.Glyph")));
            this.BarBtnCerrar.Id = 5;
            this.BarBtnCerrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarBtnCerrar.LargeGlyph")));
            this.BarBtnCerrar.Name = "BarBtnCerrar";
            this.BarBtnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnCerrar_ItemClick);
            // 
            // BarMdiChildrenList
            // 
            this.BarMdiChildrenList.Caption = "Ventanas";
            this.BarMdiChildrenList.Glyph = ((System.Drawing.Image)(resources.GetObject("BarMdiChildrenList.Glyph")));
            this.BarMdiChildrenList.Id = 6;
            this.BarMdiChildrenList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BarMdiChildrenList.LargeGlyph")));
            this.BarMdiChildrenList.Name = "BarMdiChildrenList";
            // 
            // rpCatalogos
            // 
            this.rpCatalogos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgCatalogos,
            this.RpgConfig});
            this.rpCatalogos.Name = "rpCatalogos";
            this.rpCatalogos.Text = "Catálogos";
            // 
            // rpgCatalogos
            // 
            this.rpgCatalogos.AllowTextClipping = false;
            this.rpgCatalogos.ItemLinks.Add(this.BarBtnMercancias);
            this.rpgCatalogos.ItemLinks.Add(this.BarBtnClientes);
            this.rpgCatalogos.Name = "rpgCatalogos";
            this.rpgCatalogos.ShowCaptionButton = false;
            this.rpgCatalogos.Text = "Catálogos";
            // 
            // RpgConfig
            // 
            this.RpgConfig.ItemLinks.Add(this.SRG);
            this.RpgConfig.ItemLinks.Add(this.BarMdiChildrenList, true);
            this.RpgConfig.ItemLinks.Add(this.BarBtnCerrar);
            this.RpgConfig.Name = "RpgConfig";
            this.RpgConfig.ShowCaptionButton = false;
            this.RpgConfig.Text = "Configuración";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 478);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RbMain;
            this.ribbonStatusBar.Size = new System.Drawing.Size(761, 31);
            // 
            // ribbonPageSkins
            // 
            this.ribbonPageSkins.Name = "ribbonPageSkins";
            this.ribbonPageSkins.Text = "Skins";
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 509);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.RbMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.RbMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "C.O.M.E.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rpCatalogos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCatalogos;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BarBtnMercancias;
        private DevExpress.XtraBars.BarButtonItem BarBtnClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSkins;
        private DevExpress.XtraBars.Ribbon.RibbonControl RbMain;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem SRG;
        private DevExpress.XtraBars.BarButtonItem BarBtnCerrar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgConfig;
        private DevExpress.XtraBars.BarMdiChildrenListItem BarMdiChildrenList;
    }
}