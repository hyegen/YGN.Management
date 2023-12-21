using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Management.DetailForms;

namespace YGN.Management.Forms
{
    public partial class ClientsForm : DevExpress.XtraEditors.XtraForm
    {
        #region members
        EntityModelContainer dbcontext;
        #endregion

        #region constructor
        public ClientsForm()
        {
            dbcontext = new EntityModelContainer();
            InitializeComponent();
        }
        #endregion

        #region events
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm();
            newClientForm.ShowDialog();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getData();
        }
        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void clientGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                // Sağ tık menüsü oluştur
                DXMenuItem menuItemExportToPdf = new DXMenuItem("PDF'e Aktar", new EventHandler(ExportToPdf_Click));
                e.Menu.Items.Add(menuItemExportToPdf);
            }
        }
        #endregion

        #region methods
        private void getData()
        {
            clientGridControl.DataSource = dbcontext.CLIENT.ToList();
        }
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clientGridView.OptionsPrint.ExpandAllDetails = true;
                    clientGridView.ExportToPdf(saveFileDialog.FileName);
                    XtraMessageBox.Show("Başarıyla PDF'e aktarılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
      
    }
}