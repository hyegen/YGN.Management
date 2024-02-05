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

namespace YGN.Management.Managers
{
    public class PurchasingDetailManager
    {
        ItemManager itemManager = new ItemManager(new EfItemDal());
        public PurchasingDetailManager()
        {
            
        }
        public void Show()
        {
            PurchasingForm purchasingForm = new PurchasingForm();
            purchasingForm.ItemDataSource = getData();
            purchasingForm.Show();
        }
        private List<Item_View> getData()
        {
            return itemManager.GetItemForFillingPurchaseGrid();
        }
    }
}
