using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Concrete;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using DevExpress.XtraBars;
using static Entities.Extensions.Extensions;
using YGN.Management.DetailForms;

namespace YGN.Management.SelectionForms
{
    public partial class ItemSelectionForm : XtraForm
    {
        #region members
        ItemManager itemManager = new ItemManager(new EfItemDal());
        OrderLineManager orderLineManager = new OrderLineManager(new EfOrderLineDal());
        private List<Item> _returnedList;

        #endregion

        #region constructor
        public ItemSelectionForm()
        {
            InitializeComponent();
            returnedList = new List<Item>();
        }
        #endregion

        #region properties
        //public List<Item> returnedList
        //{
        //    get { return _returnedList; }
        //    set { _returnedList = value; }
        //}
        public List<Item> returnedList
        {
            get { return _returnedList; }
            set { _returnedList = value; }
        }
        #endregion

        #region private methods
        private void getClients()
        {
            itemGridControl.DataSource = itemManager.GetAllItemsByProcedure();
        }
        #endregion

        #region events
        private void ItemSelectionForm_Load(object sender, EventArgs e)
        {
            getClients();
        }

        private void itemGridView_DoubleClick(object sender, EventArgs e)
        {
            //int selectedRowID = Convert.ToInt32(itemGridView.GetFocusedRowCellValue("Id"));
            //int[] selectedRowHandles = itemGridView.GetSelectedRows();
            //// var result = itemManager.GetItemById(selectedRowID);
            //var result = orderLineManager.GetOrderLine();
            //_returnedList.AddRange(result);
            //PurchasingForm purchasingForm = new PurchasingForm();
            //purchasingForm.OrderLineDataSource = _returnedList;

            //foreach (var item in selectedRowHandles)
            //{


            //    //List<OrderLine_View> rowData = (List<OrderLine_View>)itemGridView.GetRow(item);
            //    //  _returnedList.AddRange(rowData);
            //}
            //this.Close();
        }
        #endregion

        private void saveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult = DialogResult.OK;

            int[] selectedRowHandles = itemGridView.GetSelectedRows();

            List<Item> selectedRows = new List<Item>();

            foreach (int rowHandle in selectedRowHandles)
            {
                if (rowHandle >= 0)
                {
                    Item rowData = (Item)itemGridView.GetRow(rowHandle);
                    _returnedList.Add(rowData);
                }
            }


            //int selectedRowID = Convert.ToInt32(itemGridView.GetFocusedRowCellValue("Id"));
            //var result = itemManager.GetItemById(selectedRowID);
            //_returnedList.Add(result);

            Close();

        }

        private void closeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }


    }
}