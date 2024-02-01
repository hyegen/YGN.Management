
namespace YGN.Management.SelectionForms
{
    partial class ItemSelectionForm
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
            this.itemGridControl = new DevExpress.XtraGrid.GridControl();
            this.itemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridControl
            // 
            this.itemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridControl.Location = new System.Drawing.Point(0, 0);
            this.itemGridControl.MainView = this.itemGridView;
            this.itemGridControl.Name = "itemGridControl";
            this.itemGridControl.Size = new System.Drawing.Size(661, 324);
            this.itemGridControl.TabIndex = 0;
            this.itemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.itemGridView});
            // 
            // itemGridView
            // 
            this.itemGridView.GridControl = this.itemGridControl;
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.DoubleClick += new System.EventHandler(this.itemGridView_DoubleClick);
            // 
            // ItemSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 324);
            this.Controls.Add(this.itemGridControl);
            this.Name = "ItemSelectionForm";
            this.Text = "Malzeme - Seç";
            this.Load += new System.EventHandler(this.ItemSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl itemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView itemGridView;
    }
}