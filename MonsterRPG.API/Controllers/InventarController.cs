using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class InventarController : Controller
    {
        [HttpGet("/item")]
        public ActionResult GetItemInInventar()
        {
            // if was true List
            return Ok(new List<ItemModel>());
        }
        //api/inventaer/item
        //[HttpPost("/item")]
        //public ActionResult<ItemModel> AddItemInInventar()
        //{
        //    return Ok("Item was add in inventar");
        //}
        //api/inventar/item

        //api/inventar/item/2
        //[HttpDelete("/item/{id}")]
        //public ActionResult SoftDeleteItemInInventar(int id)
        //{
        //    return Ok("Item was deleted");
        //}

    }
}
