using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class ItemController : Controller
    {
        [HttpGet("{id}")]
        public ActionResult<ItemModel> GetItemById(int id)
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ItemModel>> GetItems()
        {
            return Ok(new List<ItemModel>());

        }

        [HttpPost]
        public ActionResult AddItem(ItemModel item)
        {
            if (item == null) return BadRequest();

            else return Ok($"{item} - was add");
        }

        [HttpDelete]
        public ActionResult DeleteItem(int id)
        {
            return Ok("Was Deleted");
        }

        [HttpPut("{id}")]
        public ActionResult SoftDeleteItem(int id)
        {
            return Ok("Was Deleted");
        }
        [HttpPut]
        public ActionResult UpdateIten(int id, ItemModel item)
        {
            return Ok($"{item} - was update");
        }
    }
}
