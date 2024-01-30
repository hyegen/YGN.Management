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
using YGN.Management.DetailForms;
using static Entities.Extensions.Extensions;

namespace YGN.Management.SelectionForms
{
    public partial class ClientSelectionForm : XtraForm
    {
        #region members

        ClientManager clientManager = new ClientManager(new EfClientDal());
        private PurchasingForm detailForm;
        private Client_View client;

        #endregion

        #region constructor
        public ClientSelectionForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void ClientSelectionForm_Load(object sender, EventArgs e)
        {
            getClients();
        }
        #endregion

        #region private methods

        private void getClients()
        {
            clientsGridControl.DataSource = clientManager.GetAllClients();
        }


        #endregion

        private void clientsGridView_DoubleClick(object sender, EventArgs e)
        {
            var a = clientsGridView.GetFocusedRow();
        }

        private void clientsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var rowHandle = clientsGridView.FocusedRowHandle;

            int val = Convert.ToInt32(clientsGridView.GetRowCellValue(rowHandle, "Id"));
            string clientCode = clientsGridView.GetRowCellValue(rowHandle, "ClientCode").ToString();
            string clientName = clientsGridView.GetRowCellValue(rowHandle, "ClientName").ToString();
            string clientSurname = clientsGridView.GetRowCellValue(rowHandle, "ClientSurname").ToString();
            string address = clientsGridView.GetRowCellValue(rowHandle, "Address").ToString();
            string firmDescription = clientsGridView.GetRowCellValue(rowHandle, "FirmDescription").ToString();
            string telNr1 = clientsGridView.GetRowCellValue(rowHandle, "TelNr1").ToString();
            string telNr2 = clientsGridView.GetRowCellValue(rowHandle, "TelNr2").ToString();
            string taxId = clientsGridView.GetRowCellValue(rowHandle, "TaxIdentificationNumber").ToString();



            var result = new Client_View
            {
                Id = val,
                ClientCode = clientCode,
                ClientName = clientName,
                ClientSurname = clientSurname,
                Address = address,
                FirmDescription = firmDescription,
                TelNr1 = string.IsNullOrEmpty(telNr1) ? "" : "",
                TelNr2 = string.IsNullOrEmpty(telNr2) ? "" : "",
                TaxIdentificationNumber = string.IsNullOrEmpty(taxId) ? "" : ""
            };

            client = result;
            //detailForm.CurrClient = result;
        }
    }
}