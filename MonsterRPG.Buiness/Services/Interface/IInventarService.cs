using MonsterRPG.Buiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services.Interface
{
    public interface IInventarService
    {
        ItemModel AddItemInInventar(ItemModel item);
        ItemModel UpdateCounItemInInventar (ItemModel item);
        ItemModel DeleteItemInInventar(ItemModel item);
        List<ItemModel> GetItemsInInventar();
        ItemModel GetItemById(int id);
    }
}
