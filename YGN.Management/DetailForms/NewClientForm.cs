using Commons.Enums;
using DevExpress.XtraEditors;
using Entities;
using Entities.Concrete;
using FluentValidation.Results;
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
using YGN.BusinessLayer.FluentValidation;
using YGN.DataAccesLayer.Concrete.EntityFramework;

namespace YGN.Management.DetailForms
{
    public partial class NewClientForm : XtraForm
    {
        #region members
        ClientManager clientManager = new ClientManager(new EfClientDal());
        StringBuilder stringBuilder = new StringBuilder();
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
            var addClient = new Client
            {
                ClientName = ClientName,
                ClientSurname = ClientSurname,
                Email = ClientEmail,
                FirmDescription = ClientFirmDescription,
                TelNr1 = ClientTelNr1,
                TelNr2 = ClientTelNr2,
                TaxIdentificationNumber = ClientTaxNr
            };

            ClientValidator itemValidator = new ClientValidator();
            ValidationResult result = itemValidator.Validate(addClient);
            if (result.IsValid)
            {
                clientManager.addClient(addClient);
                XtraMessageBox.Show(string.Format("{0} {1} olarak tanımlanan cari başarıyla eklenmiştir.", addClient.ClientName, addClient.ClientSurname), "Bilgi");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    stringBuilder.AppendLine(item.ErrorMessage);
                }
                XtraMessageBox.Show(stringBuilder.ToString(), "Error");
                Close();
            }
        }

        public void addToTransaction()
        {

        }
    
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
        public string ClientEmail
        {
            get { return emailTextEdit.Text; }
            set { emailTextEdit.Text = value; }
        }
        public string ClientFirmDescription
        {
            get { return firmTextEdit.Text; }
            set { firmTextEdit.Text = value; }
        }
        public string ClientTelNr1
        {
            get { return clientTelNr1textEdit.Text; }
            set { clientTelNr1textEdit.Text = value; }
        }
        public string ClientTelNr2
        {
            get { return clientTelNr2textEdit.Text; }
            set { clientTelNr2textEdit.Text = value; }
        }
        public string ClientTaxNr
        {
            get { return taxNrTextEdit.Text; }
            set { taxNrTextEdit.Text = value; }
        }
        #endregion

    }
}