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

namespace YGN.Management.SelectionForms
{
    public partial class ItemSelectionForm : XtraForm
    {
        #region members
        ItemManager itemManager = new ItemManager(new EfItemDal());
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

        private void ItemSelectionForm_Load(object sender, EventArgs e)
        {
            getClients();
        }

        private void itemGridView_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowID = Convert.ToInt32(itemGridView.GetFocusedRowCellValue("Id"));
            var result = itemManager.GetItemById(selectedRowID);
            _returnedList.Add(result);

            this.Close();
        }
    }
}