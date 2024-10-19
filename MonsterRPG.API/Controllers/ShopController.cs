using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class ShopController : Controller
    {
        //api/shop/item
        [HttpPost("/item")]
        public ActionResult AddNewItemInShop([FromBody] ItemModel item)
        {
            return Ok($"{item} - was add in shop");
        }
        //api/shop/items
        [HttpGet("/items")]
        public ActionResult<ItemModel> GetAllListItemInShop()
        {
            return Ok( new List<ItemModel>());
        }
        // api/shop/item/2
        [HttpDelete("/item/{id}")]
        public ActionResult SoftDeleteItemInShop(int id)
        {
            return Ok("Was deleted!");
        }

    }
}
