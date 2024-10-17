using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class InventarController : Controller
    {
        [HttpPost]
        public ActionResult<ItemModel> AddItemInInventar()
        {
            return Ok("Item was add in inventar");
        }

        [HttpGet]
        public ActionResult GetItemInInventar()
        {
            // if was true List
            return Ok(new List<ItemModel>());
        }

    }
}
