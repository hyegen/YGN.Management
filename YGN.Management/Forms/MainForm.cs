using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.DetailForms;
using YGN.Management.Managers;
using YGN.Management.OrderFicheMaker;

namespace YGN.Management.Forms
{
    public partial class MainForm : XtraForm
    {
        #region members

        StockTransactionManager stockTransactionManager = new StockTransactionManager(new EfStockTransactionDal());

        #endregion

        #region constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void MainForm_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void itemsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }

        private void clientBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void refreshBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
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
            var result = stockTransactionManager.GetStockTransactions();
            gridControlMainForm.DataSource = result;
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
        private void purchaseBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            new PurchasingDetailManager().Show();
        }

        #endregion

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderFicheMakerForm maker = new OrderFicheMakerForm();
            maker.Show();
        }
    }
}