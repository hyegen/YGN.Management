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
        public delegate void RowSelectedEventHandler(int selectedRowID);
        public event RowSelectedEventHandler RowSelected;

        #region members
        private Guid? salesId;
        ClientManager clientManager = new ClientManager(new EfClientDal());
        private PurchasingForm detailForm;
        private IList<Client_View> client;

        #endregion

        #region constructor
        public ClientSelectionForm()
        {
            InitializeComponent();
            client = new List<Client_View>();
        }
        #endregion

        #region properties

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

 
        public class SelectedRowInfo
        {
            public int ID { get; set; }
        }

        private void clientsGridView_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowID = Convert.ToInt32(clientsGridView.GetFocusedRowCellValue("Id"));

            if (RowSelected != null)
                RowSelected(selectedRowID);

            this.Close();
        }
    }
}


