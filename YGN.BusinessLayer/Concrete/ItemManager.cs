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
        IItemDal _itemDal;
        public ItemManager(IItemDal itemDal)
        {
            _itemDal= itemDal;        
        }
        public void AddItem(Item item)
        {
            if (item ==null )
            {
                throw new ArgumentNullException(nameof(item), "Item parameter cannot be null.");
            }
            _itemDal.Add(item);
        }
        public List<Item> GetItemsAll()
        {
            return _itemDal.GetAll();
        }
    }
}
