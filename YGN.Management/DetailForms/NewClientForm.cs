using Commons.Enums;
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

namespace YGN.Management.DetailForms
{
    public partial class NewClientForm : XtraForm
    {
        #region members

        #endregion

        #region constructor
        public NewClientForm()
        {

            InitializeComponent();
        }

        #endregion

        #region events
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(ClientName) || string.IsNullOrEmpty(ClientSurname) || string.IsNullOrEmpty(ClientAddress) || string.IsNullOrEmpty(ClientStore))
            {
                XtraMessageBox.Show("Bilgileri Eksiksiz Giriniz..", "Hata");
                return;
            }
            addClient();
            addToTransaction();
        }
        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region methods

        public void addClient()
        {          
            //if (IsDuplicate(ClientName, ClientSurname, ClientAddress, ClientStore))
            //{
            //    XtraMessageBox.Show("Cari zaten eklenmiş.", "Hata");
            //    return;
            //}
            //CLIENT client = new CLIENT
            //{
            //    NAME = ClientName,
            //    SURNAME = ClientSurname,
            //    ADDRESS = ClientAddress,
            //    STORENAME = ClientStore
            //};

            //dbcontext.CLIENT.Add(client);
            //dbcontext.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı.", "Bilgi");
        }

        public void addToTransaction()
        {
            //int lastClientId = dbcontext.CLIENT.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();

            //CLIENT_TRANSACTION clientTransaction = new CLIENT_TRANSACTION
            //{
            //    CLIENTID = lastClientId,
            //    PROCESSDATE = DateTime.Now
            //};
            //dbcontext.CLIENT_TRANSACTION.Add(clientTransaction);
            //dbcontext.SaveChanges();
        }
        //private bool IsDuplicate(string name, string surname, string address, string storeName)
        //{
        //    return dbcontext.CLIENT.Any(c =>
        //        c.NAME == name &&
        //        c.SURNAME == surname &&
        //        c.ADDRESS == address &&
        //        c.STORENAME == storeName);
        //}
        #endregion

        #region properties

        public string ClientName
        {
            get { return nameTextEdit.Text; }
            set { nameTextEdit.Text = value; }
        }
        public string ClientSurname
        {
            get { return surnameTextEdit.Text; }
            set { surnameTextEdit.Text = value; }
        }
        public string ClientAddress
        {
            get { return addressTextEdit.Text; }
            set { addressTextEdit.Text = value; }
        }
        public string ClientStore
        {
            get { return firmTextEdit.Text; }
            set { firmTextEdit.Text = value; }
        }

        #endregion

    }
}