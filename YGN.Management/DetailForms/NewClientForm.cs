﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Text;
using YGN.BusinessLayer.Concrete;
using YGN.BusinessLayer.FluentValidation;
using YGN.DataAccesLayer.Concrete.EntityFramework;

namespace YGN.Management.DetailForms
{
    public partial class NewClientForm : XtraForm
    {
        #region members

        ClientManager clientManager = new ClientManager(new EfClientDal());
        ClientTransactionManager clientTransactionManager = new ClientTransactionManager(new EfClientTransactionDal());

        StringBuilder stringBuilder = new StringBuilder();

        #endregion

        #region constructor
        public NewClientForm()
        {
            InitializeComponent();
            clientCodeTextEdit.EditValue = clientManager.GetClientCode();
        }

        #endregion

        #region properties
        public string ClientCode
        {
            get { return clientCodeTextEdit.Text; }
            set { clientCodeTextEdit.Text = value; }
        }
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

        #region events
        private void saveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            addClient();
        }
        private void closeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region methods

        public void addClient()
        {
            var addClient = new Client
            {
                ClientCode = ClientCode,
                ClientName = ClientName,
                ClientSurname = ClientSurname,
                Address = ClientEmail,
                FirmDescription = ClientFirmDescription,
                TelNr1 = ClientTelNr1,
                TelNr2 = ClientTelNr2,
                TaxIdentificationNumber = ClientTaxNr
            };

            ClientValidator itemValidator = new ClientValidator();
            ValidationResult result = itemValidator.Validate(addClient);
            if (result.IsValid)
            {
                if (clientManager.IsSimilarClientExists(addClient))     //New Client Control
                {
                    XtraMessageBox.Show(string.Format("{0} kodlu cari zaten mevcut. Lütfen yeni bir cari kod giriniz.",clientCodeTextEdit.Text));
                }
                else
                {
                    clientManager.AddClient(addClient);

                    var addToTransaction = new ClientTransaction
                    {
                           ClientId=addClient.Id,
                           ProcessDate=DateTime.Now
                    };
                    clientTransactionManager.AddToTranaction(addToTransaction);
                    XtraMessageBox.Show(string.Format("{0} {1} olarak tanımlanan cari başarıyla eklenmiştir.", addClient.ClientName, addClient.ClientSurname), "Bilgi");
                }
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

        #endregion
    }
}