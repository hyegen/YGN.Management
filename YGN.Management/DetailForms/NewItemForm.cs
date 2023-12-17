using Commons.Enums;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entities.Extensions;

namespace YGN.Management.DetailForms
{
    public partial class NewItemForm : DevExpress.XtraEditors.XtraForm
    {
        #region members
        EntityModelContainer dbcontext;
        #endregion

        #region constructor
        public NewItemForm()
        {
            dbcontext = new EntityModelContainer();
            InitializeComponent();
        }
        #endregion

        #region events
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(ItemCode) || string.IsNullOrEmpty(ItemName))
            {
                XtraMessageBox.Show("Bilgileri Eksiksiz Giriniz..", "Hata");
                return;
            }
            else
            {
                addItem();
                addToTransaction();
                Close();
            }
        }
        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region methods
        public void addToTransaction()
        {
            int lastItemId = dbcontext.ITEMS.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();

            TRANSACTIONS transaction = new TRANSACTIONS
            {
                TRCODE = (int)Trcode.Giris,
                PROCESSDATE = DateTime.Now,
                ITEMID = lastItemId,
                USERID = GlobalVariables.USERID,
                AMOUNT = Amount
            };

            dbcontext.TRANSACTIONS.Add(transaction);
            dbcontext.SaveChanges();
        }

        public void addItem()
        {
            ITEMS itm = new ITEMS
            {
                ITEMCODE = ItemCode,
                ITEMNAME = ItemName
            };

            dbcontext.ITEMS.Add(itm);
            dbcontext.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı.", "Bilgi");
        }

        #endregion

        #region properties
        public string ItemCode
        {
            get { return itemCodeTextEdit.Text; }
            set { itemCodeTextEdit.Text = value; }
        }
        public string ItemName
        {
            get { return itemNameTextEdit.Text; }
            set { itemNameTextEdit.Text = value; }
        }
        public int Amount
        {
            get { return int.Parse(amountTextEdit.Text); }
            set { amountTextEdit.Text = value.ToString(); }
        }

        #endregion
    }
}