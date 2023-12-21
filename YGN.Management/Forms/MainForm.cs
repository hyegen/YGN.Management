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

namespace YGN.Management.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        #region members
        EntityModelContainer dbcontext;
        #endregion

        #region constructor
        public MainForm()
        {
            InitializeComponent();
            dbcontext = new EntityModelContainer();
        }
        #endregion

        #region events
        private void MainForm_Load(object sender, EventArgs e)
        {
            // gridControlMainForm.DataSource = dbcontext.TRANSACTIONS.ToList();
            getData();
        }
        private void itemsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }

        private void clientBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getData();
        }
        private void gridViewMainForm_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                DXMenuItem menuItemExportToPdf = new DXMenuItem("PDF'e Aktar", new EventHandler(ExportToPdf_Click));
                e.Menu.Items.Add(menuItemExportToPdf);
            }
        }
        #endregion

        #region methods
        private void getData()
        {
            var trans = (from i in dbcontext.ITEMS
                         join t in dbcontext.TRANSACTIONS on i.ID equals t.ITEMID into n
                         from yt in n.DefaultIfEmpty()
                         select new
                         {
                             i.ITEMCODE,
                             i.ITEMNAME,
                             yt.AMOUNT,
                             yt.PROCESSDATE,
                             TRCODEDescription = yt.TRCODE == 1 ? "Satınalma" : yt.TRCODE == 4 ? "Satış" : "Diğer"
                         }).ToList();
            gridControlMainForm.DataSource = trans;
        }
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gridViewMainForm.OptionsPrint.ExpandAllDetails = true;
                    gridViewMainForm.ExportToPdf(saveFileDialog.FileName);
                    XtraMessageBox.Show("Başarıyla PDF'e aktarılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
      
    }
}