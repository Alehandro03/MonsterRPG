using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class ShopController : Controller
    {
        [HttpPost]
        public ActionResult AddNewItemInShop(Item item)
        {
            return Ok($"{item} - was add in shop");
        }

        [HttpGet]
        public ActionResult<Item> GetAllListItemInShop()
        {
            return Ok( new List<Item>());
        }

        [HttpDelete]
        public ActionResult DeleteItemInShop(int id)
        {
            return Ok("Was deleted!");
        }

    }
}
