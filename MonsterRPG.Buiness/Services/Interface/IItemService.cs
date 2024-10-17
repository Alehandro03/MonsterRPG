using MonsterRPG.Buiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services.Interface
{
    public interface IItemService
    {
        ItemModel AddItem(ItemModel item);
        void ChangeItem(int id, ItemModel item);
        ItemModel GetItemById(int id);
        List<ItemModel> GetItems();
        ItemModel DeleteItem(ItemModel item);
    }
}
