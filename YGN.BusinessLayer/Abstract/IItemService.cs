using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.BusinessLayer.Abstract
{
    public interface IItemService
    {
        bool IsSimilarItem(string existItemCode, string newItemCode);
        bool IsSimilarItemExists(Item newItem);
        List<Item> GetAllItemsByProcedure();
        void AddItem(Item item);
    }
}
