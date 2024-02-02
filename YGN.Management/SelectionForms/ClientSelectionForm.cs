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
 
        private List<Client> _returnedList;
        private Client _returnOneClient;
        #endregion

        #region constructor
        public ClientSelectionForm()
        {
            InitializeComponent();
            returnedList = new List<Client>();
        }
        #endregion

        #region properties
        public List<Client> returnedList
        {
            get { return _returnedList; }
            set { _returnedList = value; }
        }
        public Client returnOneClient
        {
            get { return _returnOneClient; }
            set { _returnOneClient = value; }
        }
        #endregion

        #region events
        private void ClientSelectionForm_Load(object sender, EventArgs e)
        {
            getClients();
        }
        private void clientsGridView_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            int selectedRowID = Convert.ToInt32(clientsGridView.GetFocusedRowCellValue("Id"));
            var result = clientManager.GetClientById(selectedRowID);
            //_returnedList.Add(result);
            _returnOneClient = result;
            this.Close();
        }
        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region private methods

        private void getClients()
        {
            clientsGridControl.DataSource = clientManager.GetAllClients();
        }


        #endregion

        
    }
}


