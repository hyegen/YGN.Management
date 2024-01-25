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
    public class ItemManager : IItemService
    {
        private readonly IItemDal _itemDal;
        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }
        public void AddItem(Item item)
        {
            if (!IsSimilarItemExists(item))
            {
                _itemDal.Add(item);
            }
        }
        public List<Item> GetAllItemsByProcedure()
        {
            return _itemDal.GetAllItems();
        }
        public bool IsSimilarItemExists(Item newItem)
        {
            foreach (var existingItem in _itemDal.GetAll())
            {
                if (existingItem != null && existingItem.ItemCode != null && IsSimilarItem(existingItem.ItemCode, newItem.ItemCode))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsSimilarItem(string existItemCode, string newItemCode)
        {
            if (existItemCode == null || newItemCode == null)
            {
                return false;
            }
            return existItemCode.Equals(newItemCode, StringComparison.OrdinalIgnoreCase);
        }
        //public List<string> GetAllCategories()
        //{
        //    return _itemDal.GetCategories();
        //}
    }
}
