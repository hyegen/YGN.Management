
namespace YGN.Management.DetailForms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.itemsGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.itemsLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.itemsButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.selectedItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.selectedItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clientsGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.clientsButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.clientLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupControl)).BeginInit();
            this.itemsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGroupControl)).BeginInit();
            this.clientsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsButtonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveBarButtonItem,
            this.closeBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(850, 95);
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
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.clientsGroupControl);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.itemsGroupControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(850, 411);
            this.panelControl1.TabIndex = 2;
            // 
            // itemsGroupControl
            // 
            this.itemsGroupControl.Controls.Add(this.itemsButtonEdit);
            this.itemsGroupControl.Controls.Add(this.itemsLabelControl);
            this.itemsGroupControl.Location = new System.Drawing.Point(207, 6);
            this.itemsGroupControl.Name = "itemsGroupControl";
            this.itemsGroupControl.Size = new System.Drawing.Size(217, 75);
            this.itemsGroupControl.TabIndex = 0;
            this.itemsGroupControl.Text = "Malzemeler";
            // 
            // itemsLabelControl
            // 
            this.itemsLabelControl.Location = new System.Drawing.Point(16, 39);
            this.itemsLabelControl.Name = "itemsLabelControl";
            this.itemsLabelControl.Size = new System.Drawing.Size(41, 13);
            this.itemsLabelControl.TabIndex = 1;
            this.itemsLabelControl.Text = "Malzeme";
            // 
            // itemsButtonEdit
            // 
            this.itemsButtonEdit.Location = new System.Drawing.Point(72, 36);
            this.itemsButtonEdit.MenuManager = this.ribbonControl1;
            this.itemsButtonEdit.Name = "itemsButtonEdit";
            this.itemsButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.itemsButtonEdit.Size = new System.Drawing.Size(118, 20);
            this.itemsButtonEdit.TabIndex = 2;
            this.itemsButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.itemsButtonEdit_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.selectedItemsGridControl);
            this.groupControl1.Location = new System.Drawing.Point(5, 87);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(840, 319);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Seçilen Malzemeler";
            // 
            // selectedItemsGridControl
            // 
            this.selectedItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemsGridControl.Location = new System.Drawing.Point(2, 20);
            this.selectedItemsGridControl.MainView = this.selectedItemsGridView;
            this.selectedItemsGridControl.MenuManager = this.ribbonControl1;
            this.selectedItemsGridControl.Name = "selectedItemsGridControl";
            this.selectedItemsGridControl.Size = new System.Drawing.Size(836, 297);
            this.selectedItemsGridControl.TabIndex = 0;
            this.selectedItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.selectedItemsGridView});
            // 
            // selectedItemsGridView
            // 
            this.selectedItemsGridView.GridControl = this.selectedItemsGridControl;
            this.selectedItemsGridView.Name = "selectedItemsGridView";
            this.selectedItemsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // clientsGroupControl
            // 
            this.clientsGroupControl.Controls.Add(this.clientsButtonEdit);
            this.clientsGroupControl.Controls.Add(this.clientLabelControl);
            this.clientsGroupControl.Location = new System.Drawing.Point(5, 6);
            this.clientsGroupControl.Name = "clientsGroupControl";
            this.clientsGroupControl.Size = new System.Drawing.Size(196, 75);
            this.clientsGroupControl.TabIndex = 2;
            this.clientsGroupControl.Text = "Cariler";
            // 
            // clientsButtonEdit
            // 
            this.clientsButtonEdit.Location = new System.Drawing.Point(55, 32);
            this.clientsButtonEdit.MenuManager = this.ribbonControl1;
            this.clientsButtonEdit.Name = "clientsButtonEdit";
            this.clientsButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.clientsButtonEdit.Size = new System.Drawing.Size(118, 20);
            this.clientsButtonEdit.TabIndex = 2;
            this.clientsButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.clientsButtonEdit_ButtonClick);
            // 
            // clientLabelControl
            // 
            this.clientLabelControl.Location = new System.Drawing.Point(16, 35);
            this.clientLabelControl.Name = "clientLabelControl";
            this.clientLabelControl.Size = new System.Drawing.Size(19, 13);
            this.clientLabelControl.TabIndex = 1;
            this.clientLabelControl.Text = "Cari";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 506);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "SalesForm";
            this.Text = "Satış - Yeni ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupControl)).EndInit();
            this.itemsGroupControl.ResumeLayout(false);
            this.itemsGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGroupControl)).EndInit();
            this.clientsGroupControl.ResumeLayout(false);
            this.clientsGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsButtonEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl itemsGroupControl;
        private DevExpress.XtraEditors.LabelControl itemsLabelControl;
        private DevExpress.XtraEditors.ButtonEdit itemsButtonEdit;
        private DevExpress.XtraEditors.GroupControl clientsGroupControl;
        private DevExpress.XtraEditors.ButtonEdit clientsButtonEdit;
        private DevExpress.XtraEditors.LabelControl clientLabelControl;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl selectedItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView selectedItemsGridView;
    }
}