
namespace YGN.Management.Config
{
    partial class ConfigForm
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
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.saveAndNextSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tryConnectionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataSource = typeof(Commons.ConnectionInfo);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.saveAndNextSimpleButton);
            this.panelControl1.Controls.Add(this.tryConnectionSimpleButton);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit4);
            this.panelControl1.Controls.Add(this.textEdit3);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(611, 262);
            this.panelControl1.TabIndex = 10;
            // 
            // saveAndNextSimpleButton
            // 
            this.saveAndNextSimpleButton.Location = new System.Drawing.Point(445, 228);
            this.saveAndNextSimpleButton.Name = "saveAndNextSimpleButton";
            this.saveAndNextSimpleButton.Size = new System.Drawing.Size(150, 29);
            this.saveAndNextSimpleButton.TabIndex = 19;
            this.saveAndNextSimpleButton.Text = "Kaydet & Devam";
            this.saveAndNextSimpleButton.Click += new System.EventHandler(this.saveAndNextSimpleButton_Click);
            // 
            // tryConnectionSimpleButton
            // 
            this.tryConnectionSimpleButton.Location = new System.Drawing.Point(223, 157);
            this.tryConnectionSimpleButton.Name = "tryConnectionSimpleButton";
            this.tryConnectionSimpleButton.Size = new System.Drawing.Size(183, 35);
            this.tryConnectionSimpleButton.TabIndex = 18;
            this.tryConnectionSimpleButton.Text = "Bağlantıyı Sına";
            this.tryConnectionSimpleButton.Click += new System.EventHandler(this.tryConnectionSimpleButton_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(54, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Veritabanı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(54, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Kullanıcı Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Sunucu";
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "DatabaseName", true));
            this.textEdit4.Location = new System.Drawing.Point(140, 117);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(344, 20);
            this.textEdit4.TabIndex = 13;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "Password", true));
            this.textEdit3.Location = new System.Drawing.Point(140, 85);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(344, 20);
            this.textEdit3.TabIndex = 12;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "UserName", true));
            this.textEdit2.Location = new System.Drawing.Point(140, 53);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(344, 20);
            this.textEdit2.TabIndex = 11;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "ServerName", true));
            this.textEdit1.Location = new System.Drawing.Point(140, 21);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(344, 20);
            this.textEdit1.TabIndex = 10;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 286);
            this.Controls.Add(this.panelControl1);
            this.Name = "ConfigForm";
            this.Text = "Veritabanı Ayarla";
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource configurationBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton saveAndNextSimpleButton;
        private DevExpress.XtraEditors.SimpleButton tryConnectionSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}