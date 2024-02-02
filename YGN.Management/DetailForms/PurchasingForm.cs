using DevExpress.XtraEditors;
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
        private List<OrderLine> orderLine = new List<OrderLine>();
        private List<Item> items = new List<Item>();
        OrderFicheManager orderFicheManager = new OrderFicheManager(new EfOrderFicheDal());
        OrderLineManager orderLineManager = new OrderLineManager(new EfOrderLineDal());
        private Client cl;
        private Item itm;
        #endregion

        #region properties

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
                    cl = clientSelectionForm.returnOneClient;
                    //newClientButtonEdit.Text = string.Format(cl.ClientName + " " + cl.ClientSurname) == null ? newClientButtonEdit.Text=string.Empty;
                    if (cl != null)
                    {
                        newClientButtonEdit.Text = string.Format("{0} {1}", cl.ClientName, cl.ClientSurname);
                    }
                    else
                    {
                        newClientButtonEdit.Text = string.Empty; // veya null;
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

                    var orderFiche = new OrderFiche
                    {
                        ClientId = cl.Id,
                        ProcessDate = DateTime.Now,
                        TotalPrice = 100,
                        UserId = 1,
                    };
                    orderFicheManager.AddToOrderfiche(orderFiche);
                    foreach (var item in items)
                    {
                        var orderLine = new OrderLine
                        {
                            Amount = 5,
                            ClientId = cl.Id,
                            ItemId = item.Id,
                            ProcessDate = DateTime.Now,
                            TotalPrice = 100,
                            UserId = 1,
                            OrderFicheId = orderFiche.Id
                        };
                        orderLineManager.AddToOrderLine(orderLine);
                    }
                    //foreach (var item in itemSelectionForm.returnedList)
                    //{
                    //    var orderLine = new OrderLine
                    //    {
                    //        Amount = 5,
                    //        ClientId = cl.Id,
                    //        ItemId = item.Id,
                    //        ProcessDate = DateTime.Now,
                    //        TotalPrice = 100,
                    //        UserId = 1,
                    //        OrderFicheId = orderFiche.Id
                    //    };
                    //    orderLineManager.AddToOrderLine(orderLine);
                    //}

                    newItemButtonEdit.Text = string.Join(", ", items.Select(item => $"{item.ItemCode} - {item.ItemName}"));

                    UpdateGrid();
                }
            };
        }

        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
        #endregion

        private void addToOrderFiche(OrderFiche orderFiche)
        {
            orderFicheManager.AddToOrderfiche(orderFiche);
        }

    }
}