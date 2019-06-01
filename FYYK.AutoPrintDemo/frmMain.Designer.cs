namespace FYYK.AutoPrintDemo
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPrintDesign = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSystemSet = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUserSet = new DevExpress.XtraBars.BarButtonItem();
            this.mainPagePrint = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.imageCollection1;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.bbtnSearch,
            this.bbtnPrint,
            this.bbtnPrintDesign,
            this.bbtnToExcel,
            this.bbtnClose,
            this.bbtnSelectAll,
            this.bbtnUnSelectAll,
            this.bbtnSystemSet,
            this.bbtnUserSet});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(7);
            this.ribbonControl.MaxItemId = 59;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainPagePrint});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1712, 291);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // bbtnSearch
            // 
            this.bbtnSearch.Caption = "查询";
            this.bbtnSearch.Id = 47;
            this.bbtnSearch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSearch.ImageOptions.LargeImage")));
            this.bbtnSearch.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.bbtnSearch.Name = "bbtnSearch";
            this.bbtnSearch.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.bbtnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSearch_ItemClick);
            // 
            // bbtnPrint
            // 
            this.bbtnPrint.Caption = "打印";
            this.bbtnPrint.Id = 50;
            this.bbtnPrint.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.print_16x16;
            this.bbtnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnPrint.ImageOptions.LargeImage")));
            this.bbtnPrint.Name = "bbtnPrint";
            this.bbtnPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPrint.Tag = "";
            this.bbtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPrint_ItemClick);
            // 
            // bbtnPrintDesign
            // 
            this.bbtnPrintDesign.Caption = "打印设计";
            this.bbtnPrintDesign.Id = 52;
            this.bbtnPrintDesign.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.printdialog_16x16;
            this.bbtnPrintDesign.ImageOptions.ImageIndex = 2;
            this.bbtnPrintDesign.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnPrintDesign.ImageOptions.LargeImage")));
            this.bbtnPrintDesign.Name = "bbtnPrintDesign";
            this.bbtnPrintDesign.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPrintDesign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPrintDesign_ItemClick);
            // 
            // bbtnToExcel
            // 
            this.bbtnToExcel.Caption = "导出Excel";
            this.bbtnToExcel.Id = 53;
            this.bbtnToExcel.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.exporttoxlsx_16x16;
            this.bbtnToExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnToExcel.ImageOptions.LargeImage")));
            this.bbtnToExcel.Name = "bbtnToExcel";
            this.bbtnToExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnToExcel_ItemClick);
            // 
            // bbtnClose
            // 
            this.bbtnClose.Caption = "关闭";
            this.bbtnClose.Enabled = false;
            this.bbtnClose.Id = 54;
            this.bbtnClose.Name = "bbtnClose";
            this.bbtnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbtnSelectAll
            // 
            this.bbtnSelectAll.Caption = "全选";
            this.bbtnSelectAll.Id = 55;
            this.bbtnSelectAll.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.apply_16x16;
            this.bbtnSelectAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSelectAll.ImageOptions.LargeImage")));
            this.bbtnSelectAll.Name = "bbtnSelectAll";
            this.bbtnSelectAll.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSelectAll_ItemClick);
            // 
            // bbtnUnSelectAll
            // 
            this.bbtnUnSelectAll.Caption = "全不选";
            this.bbtnUnSelectAll.Id = 56;
            this.bbtnUnSelectAll.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.cancel_16x16;
            this.bbtnUnSelectAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnUnSelectAll.ImageOptions.LargeImage")));
            this.bbtnUnSelectAll.Name = "bbtnUnSelectAll";
            this.bbtnUnSelectAll.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnUnSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnUnSelectAll_ItemClick);
            // 
            // bbtnSystemSet
            // 
            this.bbtnSystemSet.Caption = "系统配置";
            this.bbtnSystemSet.Id = 57;
            this.bbtnSystemSet.ImageOptions.Image = global::FYYK.AutoPrintDemo.Properties.Resources.version_16x161;
            this.bbtnSystemSet.ImageOptions.LargeImage = global::FYYK.AutoPrintDemo.Properties.Resources.version_32x321;
            this.bbtnSystemSet.Name = "bbtnSystemSet";
            this.bbtnSystemSet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSystemSet_ItemClick);
            // 
            // bbtnUserSet
            // 
            this.bbtnUserSet.Caption = "用户配置";
            this.bbtnUserSet.Id = 58;
            this.bbtnUserSet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnUserSet.ImageOptions.Image")));
            this.bbtnUserSet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnUserSet.ImageOptions.LargeImage")));
            this.bbtnUserSet.Name = "bbtnUserSet";
            this.bbtnUserSet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnUserSet_ItemClick);
            // 
            // mainPagePrint
            // 
            this.mainPagePrint.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.mainPagePrint.Name = "mainPagePrint";
            this.mainPagePrint.Text = "打印报表";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSearch);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnSelectAll);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnUnSelectAll);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnPrint);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnPrintDesign);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnToExcel);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1274);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(7);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1712, 62);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 291);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(7);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1712, 983);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.gridControl1);
            this.employeesNavigationPage.Margin = new System.Windows.Forms.Padding(7);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(1712, 983);
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(7);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(1712, 983);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(7);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(1712, 983);
            this.customersLabelControl.TabIndex = 1;
            this.customersLabelControl.Text = "Customers";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1642, 432);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 1336);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem bbtnSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainPagePrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem bbtnPrint;
        private DevExpress.XtraBars.BarButtonItem bbtnPrintDesign;
        private DevExpress.XtraBars.BarButtonItem bbtnToExcel;
        private DevExpress.XtraBars.BarButtonItem bbtnClose;
        private DevExpress.XtraBars.BarButtonItem bbtnSelectAll;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnUnSelectAll;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bbtnSystemSet;
        private DevExpress.XtraBars.BarButtonItem bbtnUserSet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}