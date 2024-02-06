using CoreLayer.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Abstract;
using static Entities.Extensions.Extensions;

namespace YGN.DataAccesLayer.Concrete.EntityFramework
{
    public class EfItemDal : EfGenericRepositoryBase<Item, YGNContext>, IItemDal
    {
        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            using (YGNContext context = new YGNContext())
            {
                var itemsFromDb = context.Database.SqlQuery<Item>("EXEC YGN_GET_ALL_ITEM").ToList();
                items.AddRange(itemsFromDb);
            }
            return items;
        }
        public string GetItemCode()
        {
            string str;
            using (YGNContext context = new YGNContext())
            {
                var result = context.Database.SqlQuery<string>("EXEC YGN_ITEMCODECREATOR").FirstOrDefault();
                str = result;
            }
            return str;
        }
        public Item GetItemById(int id)
        {
            using (YGNContext context = new YGNContext())
            {
                var result = context.Database.SqlQuery<Item>($"EXEC YGN_GET_ITEM_BY_ID {id}").FirstOrDefault();
                return result;
            }
        }
        public List<Item_View> GetItemForFillingPurchaseGrid()
        {
            using (YGNContext context= new YGNContext())
            {
                var result = context.Database.SqlQuery<Item_View>($"EXEC YGN_GET_ITEM_FOR_FILLING_PURCHASE_ITEMS_GRID").ToList();
                return result;
            }
        }
        public bool DeleteItemById(int id)
        {
            using (YGNContext context = new YGNContext())
            {
                var result = Convert.ToBoolean(context.Database.ExecuteSqlCommand("EXEC YGN_DELETE_CLIENT_BY_ID {0}", id));
                return result;
            }

        }
    }
}
