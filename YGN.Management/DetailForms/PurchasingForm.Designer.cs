
namespace YGN.Management.DetailForms
{
    partial class PurchasingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.clientGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.itemsGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.selectedItemsGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.selectedItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.selectedItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clientLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.itemLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGroupControl)).BeginInit();
            this.clientGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupControl)).BeginInit();
            this.itemsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGroupControl)).BeginInit();
            this.selectedItemsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(848, 95);
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
            this.panelControl1.Controls.Add(this.selectedItemsGroupControl);
            this.panelControl1.Controls.Add(this.itemsGroupControl);
            this.panelControl1.Controls.Add(this.clientGroupControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(848, 348);
            this.panelControl1.TabIndex = 2;
            // 
            // clientGroupControl
            // 
            this.clientGroupControl.Controls.Add(this.buttonEdit1);
            this.clientGroupControl.Controls.Add(this.clientLabelControl);
            this.clientGroupControl.Location = new System.Drawing.Point(5, 6);
            this.clientGroupControl.Name = "clientGroupControl";
            this.clientGroupControl.Size = new System.Drawing.Size(172, 73);
            this.clientGroupControl.TabIndex = 0;
            this.clientGroupControl.Text = "Cariler";
            // 
            // itemsGroupControl
            // 
            this.itemsGroupControl.Controls.Add(this.buttonEdit2);
            this.itemsGroupControl.Controls.Add(this.itemLabelControl);
            this.itemsGroupControl.Location = new System.Drawing.Point(183, 6);
            this.itemsGroupControl.Name = "itemsGroupControl";
            this.itemsGroupControl.Size = new System.Drawing.Size(179, 73);
            this.itemsGroupControl.TabIndex = 1;
            this.itemsGroupControl.Text = "Malzemeler";
            // 
            // selectedItemsGroupControl
            // 
            this.selectedItemsGroupControl.Controls.Add(this.selectedItemsGridControl);
            this.selectedItemsGroupControl.Location = new System.Drawing.Point(5, 85);
            this.selectedItemsGroupControl.Name = "selectedItemsGroupControl";
            this.selectedItemsGroupControl.Size = new System.Drawing.Size(838, 258);
            this.selectedItemsGroupControl.TabIndex = 2;
            this.selectedItemsGroupControl.Text = "Seçilen Malzemeler";
            // 
            // selectedItemsGridControl
            // 
            this.selectedItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemsGridControl.Location = new System.Drawing.Point(2, 20);
            this.selectedItemsGridControl.MainView = this.selectedItemsGridView;
            this.selectedItemsGridControl.MenuManager = this.ribbonControl1;
            this.selectedItemsGridControl.Name = "selectedItemsGridControl";
            this.selectedItemsGridControl.Size = new System.Drawing.Size(834, 236);
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
            // clientLabelControl
            // 
            this.clientLabelControl.Location = new System.Drawing.Point(16, 42);
            this.clientLabelControl.Name = "clientLabelControl";
            this.clientLabelControl.Size = new System.Drawing.Size(19, 13);
            this.clientLabelControl.TabIndex = 0;
            this.clientLabelControl.Text = "Cari";
            // 
            // itemLabelControl
            // 
            this.itemLabelControl.Location = new System.Drawing.Point(14, 42);
            this.itemLabelControl.Name = "itemLabelControl";
            this.itemLabelControl.Size = new System.Drawing.Size(41, 13);
            this.itemLabelControl.TabIndex = 1;
            this.itemLabelControl.Text = "Malzeme";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(52, 39);
            this.buttonEdit1.MenuManager = this.ribbonControl1;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(99, 20);
            this.buttonEdit1.TabIndex = 1;
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Location = new System.Drawing.Point(72, 39);
            this.buttonEdit2.MenuManager = this.ribbonControl1;
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Size = new System.Drawing.Size(95, 20);
            this.buttonEdit2.TabIndex = 2;
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 443);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "PurchasingForm";
            this.Text = "Satınalma - Yeni";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGroupControl)).EndInit();
            this.clientGroupControl.ResumeLayout(false);
            this.clientGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGroupControl)).EndInit();
            this.itemsGroupControl.ResumeLayout(false);
            this.itemsGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGroupControl)).EndInit();
            this.selectedItemsGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl clientGroupControl;
        private DevExpress.XtraEditors.GroupControl selectedItemsGroupControl;
        private DevExpress.XtraGrid.GridControl selectedItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView selectedItemsGridView;
        private DevExpress.XtraEditors.LabelControl itemLabelControl;
        private DevExpress.XtraEditors.LabelControl clientLabelControl;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
    }
}