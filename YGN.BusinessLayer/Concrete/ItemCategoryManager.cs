using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.BusinessLayer.Abstract;
using YGN.DataAccesLayer.Abstract;

namespace YGN.BusinessLayer.Concrete
{
    public class ItemCategoryManager : IItemCategoryService
    {
        private readonly IItemCategoryDal _iItemcategoryDal;
        public ItemCategoryManager(IItemCategoryDal iItemcategoryDal)
        {
            _iItemcategoryDal = iItemcategoryDal;
        }
        public List<ItemCategory> GetCategories()
        {
            return _iItemcategoryDal.GetCategories();
        }
    }
}
