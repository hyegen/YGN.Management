using CoreLayer.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Extensions.Extensions;

namespace YGN.DataAccesLayer.Abstract
{
    public interface IItemDal : IEntityRepository<Item>
    {
        List<Item> GetAllItems();
        string GetItemCode();
        Item GetItemById(int id);
        List<Item_View> GetItemForFillingPurchaseGrid();
    }
}
