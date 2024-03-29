﻿
namespace YGN.Management.DetailForms
{
    partial class NewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.newItemRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.itemDetailGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.brandTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.brandLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.unitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitPriceLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.itemNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemCodeLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.itemNameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.newItemRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailGroupControl)).BeginInit();
            this.itemDetailGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // newItemRibbonControl
            // 
            this.newItemRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.newItemRibbonControl.ExpandCollapseItem.Id = 0;
            this.newItemRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.newItemRibbonControl.ExpandCollapseItem,
            this.newItemRibbonControl.SearchEditItem,
            this.saveBarButtonItem,
            this.closeBarButtonItem,
            this.barButtonItem1});
            this.newItemRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.newItemRibbonControl.MaxItemId = 4;
            this.newItemRibbonControl.Name = "newItemRibbonControl";
            this.newItemRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.newItemRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.newItemRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.newItemRibbonControl.Size = new System.Drawing.Size(391, 95);
            this.newItemRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "Kaydet";
            this.saveBarButtonItem.Id = 1;
            this.saveBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.Image")));
            this.saveBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.ImageOptions.LargeImage")));
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
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
            // itemDetailGroupControl
            // 
            this.itemDetailGroupControl.Controls.Add(this.brandTextEdit);
            this.itemDetailGroupControl.Controls.Add(this.brandLabelControl);
            this.itemDetailGroupControl.Controls.Add(this.unitPriceTextEdit);
            this.itemDetailGroupControl.Controls.Add(this.unitPriceLabelControl);
            this.itemDetailGroupControl.Controls.Add(this.itemNameTextEdit);
            this.itemDetailGroupControl.Controls.Add(this.itemCodeTextEdit);
            this.itemDetailGroupControl.Controls.Add(this.itemCodeLabelControl);
            this.itemDetailGroupControl.Controls.Add(this.itemNameLabelControl);
            this.itemDetailGroupControl.Location = new System.Drawing.Point(12, 101);
            this.itemDetailGroupControl.Name = "itemDetailGroupControl";
            this.itemDetailGroupControl.Size = new System.Drawing.Size(367, 213);
            this.itemDetailGroupControl.TabIndex = 10;
            this.itemDetailGroupControl.Text = "Yeni ";
            // 
            // brandTextEdit
            // 
            this.brandTextEdit.Location = new System.Drawing.Point(97, 139);
            this.brandTextEdit.MenuManager = this.newItemRibbonControl;
            this.brandTextEdit.Name = "brandTextEdit";
            this.brandTextEdit.Size = new System.Drawing.Size(100, 20);
            this.brandTextEdit.TabIndex = 18;
            // 
            // brandLabelControl
            // 
            this.brandLabelControl.Location = new System.Drawing.Point(42, 146);
            this.brandLabelControl.Name = "brandLabelControl";
            this.brandLabelControl.Size = new System.Drawing.Size(29, 13);
            this.brandLabelControl.TabIndex = 17;
            this.brandLabelControl.Text = "Marka";
            // 
            // unitPriceTextEdit
            // 
            this.unitPriceTextEdit.Location = new System.Drawing.Point(97, 108);
            this.unitPriceTextEdit.Name = "unitPriceTextEdit";
            this.unitPriceTextEdit.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextEdit.TabIndex = 15;
            // 
            // unitPriceLabelControl
            // 
            this.unitPriceLabelControl.Location = new System.Drawing.Point(33, 111);
            this.unitPriceLabelControl.Name = "unitPriceLabelControl";
            this.unitPriceLabelControl.Size = new System.Drawing.Size(49, 13);
            this.unitPriceLabelControl.TabIndex = 14;
            this.unitPriceLabelControl.Text = "Birim Fiyat";
            // 
            // itemNameTextEdit
            // 
            this.itemNameTextEdit.Location = new System.Drawing.Point(97, 75);
            this.itemNameTextEdit.Name = "itemNameTextEdit";
            this.itemNameTextEdit.Size = new System.Drawing.Size(238, 20);
            this.itemNameTextEdit.TabIndex = 11;
            // 
            // itemCodeTextEdit
            // 
            this.itemCodeTextEdit.EditValue = "TK";
            this.itemCodeTextEdit.Location = new System.Drawing.Point(97, 43);
            this.itemCodeTextEdit.Name = "itemCodeTextEdit";
            this.itemCodeTextEdit.Size = new System.Drawing.Size(238, 20);
            this.itemCodeTextEdit.TabIndex = 10;
            // 
            // itemCodeLabelControl
            // 
            this.itemCodeLabelControl.Location = new System.Drawing.Point(23, 46);
            this.itemCodeLabelControl.Name = "itemCodeLabelControl";
            this.itemCodeLabelControl.Size = new System.Drawing.Size(68, 13);
            this.itemCodeLabelControl.TabIndex = 9;
            this.itemCodeLabelControl.Text = "Malzeme Kodu";
            // 
            // itemNameLabelControl
            // 
            this.itemNameLabelControl.Location = new System.Drawing.Point(23, 79);
            this.itemNameLabelControl.Name = "itemNameLabelControl";
            this.itemNameLabelControl.Size = new System.Drawing.Size(59, 13);
            this.itemNameLabelControl.TabIndex = 8;
            this.itemNameLabelControl.Text = "Malzeme Adı";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 326);
            this.Controls.Add(this.itemDetailGroupControl);
            this.Controls.Add(this.newItemRibbonControl);
            this.Name = "NewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Malzeme";
            ((System.ComponentModel.ISupportInitialize)(this.newItemRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailGroupControl)).EndInit();
            this.itemDetailGroupControl.ResumeLayout(false);
            this.itemDetailGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl newItemRibbonControl;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl itemDetailGroupControl;
        private DevExpress.XtraEditors.TextEdit itemNameTextEdit;
        private DevExpress.XtraEditors.TextEdit itemCodeTextEdit;
        private DevExpress.XtraEditors.LabelControl itemCodeLabelControl;
        private DevExpress.XtraEditors.LabelControl itemNameLabelControl;
        private DevExpress.XtraEditors.TextEdit unitPriceTextEdit;
        private DevExpress.XtraEditors.LabelControl unitPriceLabelControl;
        private DevExpress.XtraEditors.LabelControl brandLabelControl;
        private DevExpress.XtraEditors.TextEdit brandTextEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}