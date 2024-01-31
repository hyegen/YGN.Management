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

        private Client_View _currClient;
        ClientManager clientManager = new ClientManager(new EfClientDal());

        #endregion

        #region properties

        public Client_View CurrClient
        {
            get { return (Client_View)bindingSource1.DataSource; }
            set
            {
                //if (_currClient != null)
                //{
                bindingSource1.DataSource = value;
                //    newClientButtonEdit.Text = _currClient.FirmDescription;
                selectedItemsGridControl.DataSource = _currClient;
                // }
            }
        }

        #endregion

        #region constructor
        public PurchasingForm()
        {
            InitializeComponent();
            
        }
        private void init()
        {
            ClientSelectionForm selectionForm = new ClientSelectionForm();
            selectionForm.RowSelected += SelectionForm_RowSelected;
            selectionForm.ShowDialog();
        }

        private void SelectionForm_RowSelected(int selectedRowID)
        {
            var result = clientManager.GetClientById(selectedRowID);
            // MessageBox.Show("Seçilen Satır ID: " + selectedRowID.ToString());
        }

        //private void SelectionForm_RowSelected(SelectedRowInfo selectedRow)
        //{
        //    // Seçilen satırın bilgilerini içeren nesneyi alabilir ve GridControl'e ekleyebilirsiniz
        //    selectedItemsGridControl.DataSource = new List<SelectedRowInfo> { selectedRow };
        //}
        #endregion

        #region events
        private void newClientButtonEdit_Click(object sender, EventArgs e)
        {
            ClientSelectionForm clientSelectionForm = new ClientSelectionForm();
            clientSelectionForm.ShowDialog();
        }

        #endregion


    }
}