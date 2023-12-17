﻿
namespace YGN.Management.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.itemsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.clientBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.reportsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlMainForm = new DevExpress.XtraGrid.GridControl();
            this.gridViewMainForm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROCESSDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormRibbonControl
            // 
            this.mainFormRibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.mainFormRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainFormRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainFormRibbonControl.ExpandCollapseItem,
            this.mainFormRibbonControl.SearchEditItem,
            this.itemsBarButtonItem,
            this.clientBarButtonItem,
            this.refreshBarButtonItem,
            this.reportsBarButtonItem});
            this.mainFormRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainFormRibbonControl.MaxItemId = 8;
            this.mainFormRibbonControl.Name = "mainFormRibbonControl";
            this.mainFormRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.mainFormRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainFormRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainFormRibbonControl.Size = new System.Drawing.Size(744, 95);
            this.mainFormRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // itemsBarButtonItem
            // 
            this.itemsBarButtonItem.Caption = "Malzemeler";
            this.itemsBarButtonItem.Id = 1;
            this.itemsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemsBarButtonItem.ImageOptions.Image")));
            this.itemsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemsBarButtonItem.ImageOptions.LargeImage")));
            this.itemsBarButtonItem.Name = "itemsBarButtonItem";
            this.itemsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemsBarButtonItem_ItemClick);
            // 
            // clientBarButtonItem
            // 
            this.clientBarButtonItem.Caption = "Cariler";
            this.clientBarButtonItem.Id = 4;
            this.clientBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clientBarButtonItem.ImageOptions.Image")));
            this.clientBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("clientBarButtonItem.ImageOptions.LargeImage")));
            this.clientBarButtonItem.Name = "clientBarButtonItem";
            this.clientBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clientBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Yenile";
            this.refreshBarButtonItem.Id = 6;
            this.refreshBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.Image")));
            this.refreshBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshBarButtonItem.ImageOptions.LargeImage")));
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // reportsBarButtonItem
            // 
            this.reportsBarButtonItem.Caption = "Raporlar";
            this.reportsBarButtonItem.Id = 7;
            this.reportsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reportsBarButtonItem.ImageOptions.Image")));
            this.reportsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("reportsBarButtonItem.ImageOptions.LargeImage")));
            this.reportsBarButtonItem.Name = "reportsBarButtonItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.itemsBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.clientBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Durum";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.reportsBarButtonItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Raporlar";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlMainForm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(744, 382);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControlMainForm
            // 
            this.gridControlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMainForm.Location = new System.Drawing.Point(2, 2);
            this.gridControlMainForm.MainView = this.gridViewMainForm;
            this.gridControlMainForm.MenuManager = this.mainFormRibbonControl;
            this.gridControlMainForm.Name = "gridControlMainForm";
            this.gridControlMainForm.Size = new System.Drawing.Size(740, 378);
            this.gridControlMainForm.TabIndex = 2;
            this.gridControlMainForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMainForm});
            // 
            // gridViewMainForm
            // 
            this.gridViewMainForm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEMCODE,
            this.colITEMNAME,
            this.colPROCESSDATE,
            this.colTRCODE,
            this.colAMOUNT});
            this.gridViewMainForm.GridControl = this.gridControlMainForm;
            this.gridViewMainForm.Name = "gridViewMainForm";
            this.gridViewMainForm.OptionsView.ShowFooter = true;
            this.gridViewMainForm.OptionsView.ShowGroupPanel = false;
            this.gridViewMainForm.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewMainForm_PopupMenuShowing);
            // 
            // colITEMCODE
            // 
            this.colITEMCODE.Caption = "Malzeme Kodu";
            this.colITEMCODE.FieldName = "ITEMCODE";
            this.colITEMCODE.Name = "colITEMCODE";
            this.colITEMCODE.Visible = true;
            this.colITEMCODE.VisibleIndex = 0;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.Caption = "Malzeme Adı";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            // 
            // colPROCESSDATE
            // 
            this.colPROCESSDATE.Caption = "İşlem Tarihi";
            this.colPROCESSDATE.FieldName = "PROCESSDATE";
            this.colPROCESSDATE.Name = "colPROCESSDATE";
            this.colPROCESSDATE.Visible = true;
            this.colPROCESSDATE.VisibleIndex = 2;
            // 
            // colTRCODE
            // 
            this.colTRCODE.Caption = "Satınalma - Satış";
            this.colTRCODE.FieldName = "TRCODEDescription";
            this.colTRCODE.Name = "colTRCODE";
            this.colTRCODE.Visible = true;
            this.colTRCODE.VisibleIndex = 3;
            // 
            // colAMOUNT
            // 
            this.colAMOUNT.Caption = "Miktar";
            this.colAMOUNT.FieldName = "AMOUNT";
            this.colAMOUNT.Name = "colAMOUNT";
            this.colAMOUNT.Visible = true;
            this.colAMOUNT.VisibleIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 477);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.mainFormRibbonControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainFormRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem itemsBarButtonItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlMainForm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMainForm;
        private DevExpress.XtraBars.BarButtonItem clientBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colITEMCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEMNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colTRCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROCESSDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colAMOUNT;
        private DevExpress.XtraBars.BarButtonItem reportsBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}