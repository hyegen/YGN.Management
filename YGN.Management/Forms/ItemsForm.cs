using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YGN.Management.DetailForms;
using static Entities.Extensions;

namespace YGN.Management.Forms
{
    public partial class ItemsForm : XtraForm
    {
        #region members
        EntityModelContainer dbcontext;
        #endregion

        #region constructor
        public ItemsForm()
        {
            InitializeComponent();
            dbcontext = new EntityModelContainer();
        }
        #endregion

        #region events
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getData();
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm();
            newItemForm.ShowDialog();
        }
        
        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void itemsGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
        public void getData()
        {
            var query = from i in dbcontext.ITEMS
                        select new ITEMS_VIEW
                        {
                            ID = i.ID,
                            ITEMCODE = i.ITEMCODE,
                            ITEMNAME = i.ITEMNAME
                        };
            itemsGridControl.DataSource = query.ToList();
        }
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            // Grid verilerini PDF'e export et
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    itemsGridView.OptionsPrint.ExpandAllDetails = true;
                    itemsGridView.ExportToPdf(saveFileDialog.FileName);
                    XtraMessageBox.Show("Başarıyla PDF'e aktarılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

    }
}