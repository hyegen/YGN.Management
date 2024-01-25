using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.DetailForms;

namespace YGN.Management.Forms
{
    public partial class ItemsForm : XtraForm
    {
        #region members
        ItemManager itemManager = new ItemManager(new EfItemDal());
        #endregion

        #region constructor
        public ItemsForm()
        {
            InitializeComponent();
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
                DXMenuItem menuItemExportToPdf = new DXMenuItem("PDF'e Aktar", new EventHandler(ExportToPdf_Click));
                e.Menu.Items.Add(menuItemExportToPdf);
            }
        }
        #endregion

        #region methods
        public void getData()
        {
            var datas = itemManager.GetAllItemsByProcedure();
            itemsGridControl.DataSource = datas;
        }
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
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