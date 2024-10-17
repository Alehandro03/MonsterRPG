using MonsterRPG.Buiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services.Interface
{
    public interface IShopService
    {
        ItemModel AddItemInShop (ItemModel item);
        ItemModel DeleteItemInShop (ItemModel item);
        List<ItemModel> GetItemsInShop();
        ItemModel GetItemById (int id);
       
    }
}
