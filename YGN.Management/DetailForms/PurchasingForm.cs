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
                if (clientSelectionForm.ShowDialog() == DialogResult.Cancel)
                {
                    clients.Clear();
                    clients.AddRange(clientSelectionForm.returnedList);
                    newClientButtonEdit.Text = string.Join(", ", clients.Select(client => $"{client.ClientName} {client.ClientSurname}"));

                   // UpdateGrid();
                }
            };
        }

        private void UpdateGrid()
        {
            selectedItemsGridView.BeginUpdate();

            try
            {
                selectedItemsGridView.Columns.Clear();  
                selectedItemsGridView.Columns.AddVisible("Id", "Id");     
                selectedItemsGridView.Columns.AddVisible("ItemCode", "Item Code");     
                selectedItemsGridControl.DataSource = items;
                selectedItemsGridView.RefreshData();
            }
            finally
            {
                selectedItemsGridView.EndUpdate();
            }
        }
        #endregion

        private void newItemButtonEdit_Click(object sender, EventArgs e)
        {
            using (ItemSelectionForm itemSelectionForm = new ItemSelectionForm())
            {
                if (itemSelectionForm.ShowDialog() == DialogResult.Cancel)
                {
                    items.Clear();
                    items.AddRange(itemSelectionForm.returnedList);
                    newItemButtonEdit.Text = string.Join(", ", items.Select(item => $"{item.ItemCode} - {item.ItemName}"));

                    UpdateGrid();
                }
            };
        }
    }
}