
namespace YGN.Management.Forms
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.itemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.itemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveBarButtonItem,
            this.closeBarButtonItem,
            this.refreshBarButtonItem});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // saveBarButtonItem
            // 
            resources.ApplyResources(this.saveBarButtonItem, "saveBarButtonItem");
            this.saveBarButtonItem.Id = 1;
            this.saveBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.Image")));
            this.saveBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.LargeImage")));
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
            // 
            // closeBarButtonItem
            // 
            resources.ApplyResources(this.closeBarButtonItem, "closeBarButtonItem");
            this.closeBarButtonItem.Id = 2;
            this.closeBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeBarButtonItem.ImageOptions.Image")));
            this.closeBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("closeBarButtonItem.ImageOptions.LargeImage")));
            this.closeBarButtonItem.Name = "closeBarButtonItem";
            this.closeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.closeBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            resources.ApplyResources(this.refreshBarButtonItem, "refreshBarButtonItem");
            this.refreshBarButtonItem.Id = 3;
            this.refreshBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.Image")));
            this.refreshBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.LargeImage")));
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.closeBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.itemsGridControl);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // itemsGridControl
            // 
            resources.ApplyResources(this.itemsGridControl, "itemsGridControl");
            this.itemsGridControl.MainView = this.itemsGridView;
            this.itemsGridControl.MenuManager = this.ribbonControl1;
            this.itemsGridControl.Name = "itemsGridControl";
            this.itemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.itemsGridView});
            // 
            // itemsGridView
            // 
            this.itemsGridView.GridControl = this.itemsGridControl;
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.OptionsBehavior.Editable = false;
            this.itemsGridView.OptionsView.ShowGroupPanel = false;
            this.itemsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.itemsGridView_PopupMenuShowing);
            // 
            // ItemsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl itemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView itemsGridView;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}