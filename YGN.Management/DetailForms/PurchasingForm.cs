using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

        #endregion

        #region properties
        private List<OrderLine_View> DataSource
        {
            get { return (List<OrderLine_View>)selectedItemsBindingSource.DataSource; }
            set { selectedItemsBindingSource.DataSource = value; }
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
            using (ItemSelectionForm itemSelectionForm = new ItemSelectionForm())
            {
                if (itemSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    items.Clear();
                    items.AddRange(itemSelectionForm.returnedList);
                    newItemButtonEdit.Text = string.Join(", ", items.Select(item => $"{item.ItemCode} - {item.ItemName}"));
                    //UpdateGrid();
                    
                    selectedItemsGridControl.DataSource = DataSource;

                    //var orderFiche = new OrderFiche
                    //{
                    //    ClientId = _client.Id,
                    //    ProcessDate = DateTime.Now,
                    //    TotalPrice = 100,
                    //    UserId = 1,
                    //};

                    //orderFicheManager.AddToOrderfiche(orderFiche);



                    //foreach (var item in items)
                    //{
                    //    var x = new OrderLine_View
                    //    {
                    //        ClientId = _client.Id,
                    //        Amount = amountValue,
                    //        ItemId = item.Id,
                    //        OrderFicheId = orderFiche.Id,
                    //        ProcessDate = DateTime.Now,
                    //        TotalPrice = amountValue * item.UnitPrice,
                    //        UserId = 1
                    //    };
                    //}

                    selectedItemsGridControl.DataSource = DataSource;
                }
            };
        }

        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateSave())
            {
                addToOrderFicheAndSave();
            }
            else
            {
                XtraMessageBox.Show("Malzeme(ler) veya Cari seçilmemiş. Lütfen seçiniz.", "Hata");
            }
            Close();
        }

        #endregion

        #region private methods
        private void UpdateGrid()
        {
            selectedItemsGridView.BeginUpdate();

            try
            {
                selectedItemsGridView.Columns.Clear();
                selectedItemsGridView.Columns.AddVisible("Id", "Id");
                selectedItemsGridView.Columns.AddVisible("ItemCode", "Malzeme Kodu");
                selectedItemsGridView.Columns.AddVisible("ItemName", "Malzeme Adı");

                selectedItemsGridControl.DataSource = items;
                selectedItemsGridView.RefreshData();
            }
            finally
            {
                selectedItemsGridView.EndUpdate();
            }
        }

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
                int selectedRowHandle = selectedItemsGridView.FocusedRowHandle;

                int amountColumnIndex = selectedItemsGridView.Columns["Amount"].VisibleIndex;
                double amountValue = Convert.ToDouble(selectedItemsGridView.GetRowCellValue(selectedRowHandle, amountColumnIndex.ToString()));

                var orderLine = new OrderLine
                {
                    Amount = amountValue,
                    ClientId = _client.Id,
                    ItemId = item.Id,
                    ProcessDate = DateTime.Now,
                    TotalPrice = 100,
                    UserId = 1,
                    OrderFicheId = orderFiche.Id
                };
                orderLineManager.AddToOrderLine(orderLine);
            }
            //  XtraMessageBox.Show("{0} kodlu, ");
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
    }
}