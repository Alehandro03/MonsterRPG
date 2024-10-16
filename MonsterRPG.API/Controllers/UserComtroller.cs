using Microsoft.AspNetCore.Mvc;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class UserComtroller : Controller
    {
        [HttpPost]
        public ActionResult AddUser()
        {
            return Ok("Успешно добавлен");
        }

        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {
            return NoContent();
        }

        [HttpGet]
        public ActionResult GetUserById(int id)
        {
            //Если не нашли то
            return NotFound($"User{id} was noy found");

            //если нашли то

            //return Ok(new User());
        }
    }

}
