using MonsterRPG.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Repositories.Interface
{
    public interface IInventarRepository
    {
        Item AddItemInInventar(Item item, Inventar inventar);
        Item UpdateCounItemInInventar(Item item);
        Item DeleteItemInInventar(Item item);
        List<Item> GetItemsInInventar();
        Item GetItemById(int id);
    }
}
