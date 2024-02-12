using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Entities.Concrete;
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
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.Managers;
using YGN.Management.OrderFicheMaker;
using YGN.Management.SelectionForms;
using static Entities.Extensions.Extensions;
using static YGN.Management.SelectionForms.ClientSelectionForm;

namespace YGN.Management.DetailForms
{
    public partial class PurchasingForm : XtraForm
    {
        #region members

        private List<Client> clients = new List<Client>();
        private List<Item> items = new List<Item>();
        private Client _client;
        OrderFicheManager orderFicheManager = new OrderFicheManager(new EfOrderFicheDal());
        OrderLineManager orderLineManager = new OrderLineManager(new EfOrderLineDal());
        private List<Item> _lineDataSource;
        #endregion

        #region properties

        public List<Item_View> ItemDataSource
        {
            get { return (List<Item_View>)itemsBindingSource.DataSource; }
            set { itemsBindingSource.DataSource = value; }
        }
        public List<OrderLine_View> OrderLineDataSource
        {
            get { return (List<OrderLine_View>)selectedItemsBindingSource.DataSource; }
            set { selectedItemsBindingSource.DataSource = value; }
        }
        public OrderLine_View SelectedLine
        {
            get
            {
                var gridView = itemsGridControl.FocusedView as GridView;
                if (gridView != null)
                    return (OrderLine_View)gridView.GetFocusedRow();
                return null;
            }
        }
        public List<Item> LineDataSource
        {
            get { return _lineDataSource; }
            set
            {
                _lineDataSource = value;
            }
        }
        #endregion

        #region constructor
        public PurchasingForm()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void newClientButtonEdit_Click(object sender, EventArgs e)
        {
            using (ClientSelectionForm clientSelectionForm = new ClientSelectionForm())
            {
                if (clientSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    clients.Clear();
                    _client = clientSelectionForm.returnOneClient;
                    if (_client != null)
                    {
                        newClientButtonEdit.Text = string.Format("{0} {1}", _client.ClientName, _client.ClientSurname);
                    }
                    else
                    {
                        newClientButtonEdit.Text = string.Empty;
                    }

                }
            };
        }
        private void newItemButtonEdit_Click(object sender, EventArgs e)
        {
            //using (ItemSelectionForm itemSelectionForm = new ItemSelectionForm())
            //{
            //    if (itemSelectionForm.ShowDialog() == DialogResult.OK)
            //    {
            //        items.Clear();
            //        //  items.AddRange(itemSelectionForm.returnedList);
            //        //  newItemButtonEdit.Text = string.Join(", ", items.Select(item => $"{item.ItemCode} - {item.ItemName}"));
            //        newItemButtonEdit.Text = string.Join(", ", items.Select(item => $"{item.ItemCode}"));
            //        selectedItemsGridControl.DataSource = itemSelectionForm.returnedList;  //itemSelectionForm.returnedList;
            //    }
            //};
            new PurchasingDetailManager().itemSelection();
        }
        private void closeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        private void saveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validateSave())
            {
                //addToOrderFicheAndSave();
            }
            else
            {
                XtraMessageBox.Show("Malzeme(ler) veya Cari seçilmemiş. Lütfen seçiniz.", "Hata");
            }
            Close();
        }

        #endregion

        #region private methods

        private void createOrderFiche()
        {
            OrderFicheXtraReport xtraReport = new OrderFicheXtraReport();
            // xtraReport.ShowRibbonPreview();
            ReportDesignTool reportDesignTool = new ReportDesignTool(xtraReport);

            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Black";
            reportDesignTool.ShowRibbonDesignerDialog(lookAndFeel);
        }

        //private void UpdateGrid()
        //{
        //    itemsGridView.BeginUpdate();

        //    try
        //    {
        //        itemsGridView.Columns.Clear();
        //        itemsGridView.Columns.AddVisible("Id", "Id");
        //        itemsGridView.Columns.AddVisible("ItemCode", "Malzeme Kodu");
        //        itemsGridView.Columns.AddVisible("ItemName", "Malzeme Adı");

        //        itemsGridControl.DataSource = items;
        //        itemsGridView.RefreshData();
        //    }
        //    finally
        //    {
        //        itemsGridView.EndUpdate();
        //    }
        //}

        private void addToOrderFicheAndSave()
        {
            var orderFiche = new OrderFiche
            {
                ClientId = _client.Id,
                ProcessDate = DateTime.Now,
                TotalPrice = 100,
                UserId = 1,
            };

            orderFicheManager.AddToOrderfiche(orderFiche);
            foreach (var item in items)
            {
                int selectedRowHandle = itemsGridView.FocusedRowHandle;

                int unitPriceColumnIndex = itemsGridView.Columns["UnitPrice"].VisibleIndex;
                double unitPriceValue = Convert.ToDouble(itemsGridView.GetRowCellValue(selectedRowHandle, unitPriceColumnIndex.ToString()));

                var orderLine = new OrderLine
                {
                    Amount = unitPriceValue,
                    ClientId = _client.Id,
                    ItemId = item.Id,
                    ProcessDate = DateTime.Now,
                    TotalPrice = 100,
                    UserId = 1,
                    OrderFicheId = orderFiche.Id
                };
                orderLineManager.AddToOrderLine(orderLine);
            }
            XtraMessageBox.Show("Satınalma başarılı.");
        }

        private bool validateSave()
        {
            if (!items.Any() || _client == null)
            {
                return false;
            }
            return true;
        }

        #endregion

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            createOrderFiche();
        }

        private void selectedItemsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == columnAmount)
            {
                var row = (Item)selectedItemsGridView.GetRow(e.RowHandle);
                Item dataRow = _lineDataSource.FirstOrDefault();
                dataRow.Amount = row.Amount;
            }
        }

    }
}