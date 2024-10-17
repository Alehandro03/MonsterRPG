using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class InventarController : Controller
    {
        [HttpPost]
        public ActionResult<Item> AddItemInInventar()
        {
            return Ok("Item was add in inventar");
        }

        [HttpGet]
        public ActionResult GetItemInInventar()
        {
            return Ok(new List<Item>());
        }

    }
}
