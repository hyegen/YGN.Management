using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.DetailForms;
using static Entities.Extensions.Extensions;
using Entities.Concrete;
using YGN.Management.SelectionForms;

namespace YGN.Management.Managers
{
    public class PurchasingDetailManager
    {
        PurchasingForm purchasingForm = new PurchasingForm();
        ItemSelectionForm itemSelectionForm = new ItemSelectionForm();
        ItemManager itemManager = new ItemManager(new EfItemDal());
        public PurchasingDetailManager()
        {

        }
        public void Show()
        {
            // purchasingForm.LineDataSource = getData();
            purchasingForm.Show();
            purchasingForm.LineDataSource = getData();
            //foreach (var item in lineList)
            //{
            //    addToList(lineList,item);
            //}

        }
        private List<Item> getData()
        {
            return itemManager.GetAllItemsByProcedure();
            //return itemManager.GetItemForFillingPurchaseGrid();
        }

        public void itemSelection()
        {
            if (itemSelectionForm.ShowDialog() == DialogResult.OK)
            {
                //itemSelectionForm.returnedList.ToList();
                var a = itemSelectionForm.returnedList;
                addToList(a);
                //foreach (var item in a)
                //{
                //    addToList(item);
                //}
            }
        }
        public void addToList(List<Item> orderLineList)
        {
            purchasingForm.LineDataSource.AddRange(orderLineList);
        }
    }
}
