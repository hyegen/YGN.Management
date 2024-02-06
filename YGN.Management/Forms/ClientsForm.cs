using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
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
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.DetailForms;

namespace YGN.Management.Forms
{
    public partial class ClientsForm : XtraForm
    {
        #region members
        ClientManager clientManager = new ClientManager(new EfClientDal());
        #endregion

        #region constructor
        public ClientsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void saveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm();
            newClientForm.ShowDialog();
            getData();
        }
        private void refreshBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            getData();
        }
        private void closeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        private void clientGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                // Sağ tık menüsü oluştur
                DXMenuItem menuItemExportToPdf = new DXMenuItem("PDF'e Aktar", new EventHandler(ExportToPdf_Click));
                DXMenuItem deleteClient = new DXMenuItem("Cari'yi Sil", new EventHandler(deleteClient_Click));
                e.Menu.Items.Add(menuItemExportToPdf);
                e.Menu.Items.Add(deleteClient);
            }
        }
        #endregion

        #region methods
        private void getData()
        {
            clientGridControl.DataSource = clientManager.GetAllClients();
            //clientGridControl.DataSource = dbcontext.CLIENT.ToList();
        }
        private void deleteClient_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = clientGridView.FocusedRowHandle;

            if (selectedRowHandle >= 0)
            {
                int selectedId = Convert.ToInt32(clientGridView.GetRowCellValue(selectedRowHandle, "Id"));
                string selectedClientName = clientGridView.GetRowCellValue(selectedRowHandle, "ClientName").ToString();
                string selectedClientSurname = clientGridView.GetRowCellValue(selectedRowHandle, "ClientSurname").ToString();
                var condition = clientManager.DeleteClientById(selectedId);
                if (condition)
                {
                    XtraMessageBox.Show(string.Format("{0} {1} olarak kayıtlı cari başarıyla silindi.",selectedClientName,selectedClientSurname), "Bilgi");
                }

                else
                    XtraMessageBox.Show(string.Format("{0} {1} Cari Silinirken Hata Oluştu !", selectedClientName, selectedClientSurname), "Hata");
            }
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