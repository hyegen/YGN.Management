using CoreLayer.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Abstract;

namespace YGN.DataAccesLayer.Concrete.EntityFramework
{
    public class EfItemDal : EfGenericRepositoryBase<Item, YGNContext>, IItemDal
    {
        public List<Item> getAllItems()
        {
            List<Item> items = new List<Item>();

            using (YGNContext context= new YGNContext())
            {
                var itemsFromDb = context.Database.SqlQuery<Item>("EXEC YGN_GET_ALL_ITEM").ToList();
                items.AddRange(itemsFromDb);
            }
            return items;
        }
    }
}
