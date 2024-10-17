using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;

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

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            //Если не нашли то
            return NotFound($"User{id} was noy found");

            //если нашли то

            //return Ok(new User());
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {


            return Ok( UpdateUser);
        }

        [HttpPut]
        public ActionResult<User> UpdateUser(int id)
        {
            return Ok("Успешно изменен");
        }
    }

}
