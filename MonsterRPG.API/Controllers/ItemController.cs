using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class ItemController : Controller
    {
        // api/item/2
        [HttpGet("{id}")]
        public ActionResult<ItemModel> GetItemById(int id)
        {

            return Ok();
        }
        //api/item
        [HttpGet]
        public ActionResult<List<ItemModel>> GetItems()
        {
            return Ok(new List<ItemModel>());

        }
        //api/item
        [HttpPost]
        public ActionResult AddItem(ItemModel item)
        {
            if (item == null) return BadRequest();

            else return Ok($"{item} - was add");
        }
        // api/item/2
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            return NoContent();
        }
        // api/item/2
        [HttpPut("{id}")]
        public ActionResult SoftDeleteItem(int id)
        {
            return Ok("Was Deleted");
        }
        // api/item/2
        [HttpPut("{id}/{item}")]
        public ActionResult UpdateIten(int id, [FromBody] ItemModel item)
        {
            return Ok($"{item} - was update");
        }
    }
}
