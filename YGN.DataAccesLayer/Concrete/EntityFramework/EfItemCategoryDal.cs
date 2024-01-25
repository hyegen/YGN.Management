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
    public class EfItemCategoryDal : EfGenericRepositoryBase<ItemCategory, YGNContext>, IItemCategoryDal
    {
        public List<ItemCategory> GetCategories()
        {
            using (YGNContext context = new YGNContext())
            {
                var query = from c in context.ItemCategories
                            select c;
        
                return query.ToList();
            }
        }
    }
}
