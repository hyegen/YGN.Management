
namespace YGN.Management.DetailForms
{
    partial class NewClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClientForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.clientCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientCodelabelControl = new DevExpress.XtraEditors.LabelControl();
            this.taxNrTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taxNrLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.clientTelNr2textEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientTelNr1textEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.telNr1labelControl = new DevExpress.XtraEditors.LabelControl();
            this.firmTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.surnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxNrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTelNr2textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTelNr1textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(585, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clientCodeTextEdit);
            this.groupControl1.Controls.Add(this.clientCodelabelControl);
            this.groupControl1.Controls.Add(this.taxNrTextEdit);
            this.groupControl1.Controls.Add(this.taxNrLabelControl);
            this.groupControl1.Controls.Add(this.clientTelNr2textEdit);
            this.groupControl1.Controls.Add(this.clientTelNr1textEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.telNr1labelControl);
            this.groupControl1.Controls.Add(this.firmTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.surnameTextEdit);
            this.groupControl1.Controls.Add(this.nameTextEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.emailTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 101);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(561, 298);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Yeni ";
            // 
            // clientCodeTextEdit
            // 
            this.clientCodeTextEdit.Location = new System.Drawing.Point(121, 41);
            this.clientCodeTextEdit.MenuManager = this.ribbonControl1;
            this.clientCodeTextEdit.Name = "clientCodeTextEdit";
            this.clientCodeTextEdit.Size = new System.Drawing.Size(278, 20);
            this.clientCodeTextEdit.TabIndex = 9;
            // 
            // clientCodelabelControl
            // 
            this.clientCodelabelControl.Location = new System.Drawing.Point(56, 44);
            this.clientCodelabelControl.Name = "clientCodelabelControl";
            this.clientCodelabelControl.Size = new System.Drawing.Size(46, 13);
            this.clientCodelabelControl.TabIndex = 26;
            this.clientCodelabelControl.Text = "Cari Kodu";
            // 
            // taxNrTextEdit
            // 
            this.taxNrTextEdit.Location = new System.Drawing.Point(121, 230);
            this.taxNrTextEdit.MenuManager = this.ribbonControl1;
            this.taxNrTextEdit.Name = "taxNrTextEdit";
            this.taxNrTextEdit.Size = new System.Drawing.Size(278, 20);
            this.taxNrTextEdit.TabIndex = 21;
            // 
            // taxNrLabelControl
            // 
            this.taxNrLabelControl.Location = new System.Drawing.Point(31, 233);
            this.taxNrLabelControl.Name = "taxNrLabelControl";
            this.taxNrLabelControl.Size = new System.Drawing.Size(71, 13);
            this.taxNrLabelControl.TabIndex = 20;
            this.taxNrLabelControl.Text = "Vergi Numarası";
            // 
            // clientTelNr2textEdit
            // 
            this.clientTelNr2textEdit.Location = new System.Drawing.Point(121, 203);
            this.clientTelNr2textEdit.MenuManager = this.ribbonControl1;
            this.clientTelNr2textEdit.Name = "clientTelNr2textEdit";
            this.clientTelNr2textEdit.Size = new System.Drawing.Size(278, 20);
            this.clientTelNr2textEdit.TabIndex = 19;
            // 
            // clientTelNr1textEdit
            // 
            this.clientTelNr1textEdit.Location = new System.Drawing.Point(121, 176);
            this.clientTelNr1textEdit.MenuManager = this.ribbonControl1;
            this.clientTelNr1textEdit.Name = "clientTelNr1textEdit";
            this.clientTelNr1textEdit.Size = new System.Drawing.Size(278, 20);
            this.clientTelNr1textEdit.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(61, 206);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Tel Nr. 2";
            // 
            // telNr1labelControl
            // 
            this.telNr1labelControl.Location = new System.Drawing.Point(61, 179);
            this.telNr1labelControl.Name = "telNr1labelControl";
            this.telNr1labelControl.Size = new System.Drawing.Size(41, 13);
            this.telNr1labelControl.TabIndex = 16;
            this.telNr1labelControl.Text = "Tel Nr. 1";
            // 
            // firmTextEdit
            // 
            this.firmTextEdit.Location = new System.Drawing.Point(121, 149);
            this.firmTextEdit.Name = "firmTextEdit";
            this.firmTextEdit.Size = new System.Drawing.Size(278, 20);
            this.firmTextEdit.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(74, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Adres";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Firma Adı";
            // 
            // surnameTextEdit
            // 
            this.surnameTextEdit.Location = new System.Drawing.Point(121, 95);
            this.surnameTextEdit.Name = "surnameTextEdit";
            this.surnameTextEdit.Size = new System.Drawing.Size(278, 20);
            this.surnameTextEdit.TabIndex = 11;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(121, 68);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(278, 20);
            this.nameTextEdit.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(84, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ad";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Soyad";
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.Location = new System.Drawing.Point(121, 122);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(278, 20);
            this.emailTextEdit.TabIndex = 14;
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 411);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "NewClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Ekle - Yeni ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxNrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTelNr2textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTelNr1textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit surnameTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit firmTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl telNr1labelControl;
        private DevExpress.XtraEditors.TextEdit clientTelNr2textEdit;
        private DevExpress.XtraEditors.TextEdit clientTelNr1textEdit;
        private DevExpress.XtraEditors.TextEdit taxNrTextEdit;
        private DevExpress.XtraEditors.LabelControl taxNrLabelControl;
        private DevExpress.XtraEditors.TextEdit clientCodeTextEdit;
        private DevExpress.XtraEditors.LabelControl clientCodelabelControl;
    }
}