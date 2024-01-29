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
using YGN.Management.DetailForms;
using static Entities.Extensions.Extensions;

namespace YGN.Management.SelectionForms
{
    public partial class ClientSelectionForm : XtraForm
    {
        #region members

        ClientManager clientManager = new ClientManager(new EfClientDal());
        private PurchasingForm detailForm;
        public Client_View client;

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

        private void clientsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //string selectedName = clientsGridView.GetRowCellValue(e.FocusedRowHandle, "ClientName") as string;
            //string selectedFirm = clientsGridView.GetRowCellValue(e.FocusedRowHandle, "ColumnName_Address") as string;
            //string selectedFirm = clientsGridView.GetRowCellValue(e.FocusedRowHandle, "ColumnName_Address") as string;
            //string selectedFirm = clientsGridView.GetRowCellValue(e.FocusedRowHandle, "ColumnName_Address") as string;
            //string selectedFirm = clientsGridView.GetRowCellValue(e.FocusedRowHandle, "ColumnName_Address") as string;


            //client.ClientName = selectedName;
            //detailForm.CurrClient = client;
        }

        private void ClientSelectionForm_Shown(object sender, EventArgs e)
        {
            clientsGridControl.Focus();
            clientsGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            clientsGridView.FocusedColumn =  clientsGridView.VisibleColumns[0];
        }
    }
}