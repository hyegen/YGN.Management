
namespace YGN.Management.SelectionForms
{
    partial class ClientSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSelectionForm));
            this.clientsGridControl = new DevExpress.XtraGrid.GridControl();
            this.clientsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGridControl
            // 
            this.clientsGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientsGridControl.Location = new System.Drawing.Point(0, 96);
            this.clientsGridControl.MainView = this.clientsGridView;
            this.clientsGridControl.Name = "clientsGridControl";
            this.clientsGridControl.Size = new System.Drawing.Size(900, 346);
            this.clientsGridControl.TabIndex = 0;
            this.clientsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.clientsGridView});
            // 
            // clientsGridView
            // 
            this.clientsGridView.GridControl = this.clientsGridControl;
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.OptionsBehavior.Editable = false;
            this.clientsGridView.OptionsBehavior.ReadOnly = true;
            this.clientsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.clientsGridView.OptionsView.ShowAutoFilterRow = true;
            this.clientsGridView.OptionsView.ShowGroupPanel = false;
            this.clientsGridView.OptionsView.ShowIndicator = false;
            this.clientsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.clientsGridView_CellValueChanged);
            this.clientsGridView.DoubleClick += new System.EventHandler(this.clientsGridView_DoubleClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveBarButtonItem,
            this.closeBarButtonItem,
            this.refreshBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(900, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "Kaydet";
            this.saveBarButtonItem.Id = 1;
            this.saveBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.Image")));
            this.saveBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.LargeImage")));
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            // 
            // closeBarButtonItem
            // 
            this.closeBarButtonItem.Caption = "Kapat";
            this.closeBarButtonItem.Id = 2;
            this.closeBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeBarButtonItem.ImageOptions.Image")));
            this.closeBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("closeBarButtonItem.ImageOptions.LargeImage")));
            this.closeBarButtonItem.Name = "closeBarButtonItem";
            this.closeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.closeBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Yenile";
            this.refreshBarButtonItem.Id = 4;
            this.refreshBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.Image")));
            this.refreshBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.LargeImage")));
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.closeBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Durum";
            // 
            // ClientSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 442);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.clientsGridControl);
            this.Name = "ClientSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari - Seç";
            this.Load += new System.EventHandler(this.ClientSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl clientsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView clientsGridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}