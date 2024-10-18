using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class ShopController : Controller
    {
        [HttpPost]
        public ActionResult AddNewItemInShop(ItemModel item)
        {
            return Ok($"{item} - was add in shop");
        }
        //api/items
        [HttpGet]
        public ActionResult<ItemModel> GetAllListItemInShop()
        {
            return Ok( new List<ItemModel>());
        }
        // api/prsonage/2
        [HttpDelete]
        public ActionResult DeleteItemInShop(int id)
        {
            return Ok("Was deleted!");
        }

    }
}
