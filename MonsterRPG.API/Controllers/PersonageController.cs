using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class PersonageController : Controller
    {
        [HttpGet("{id}")] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult<Personage>GetPersonageById(int id)
        {
            //Если не нашли то
            return NotFound($"Персонаж{id} не найден");

            //если нашли то

            return Ok(new Personage());
        }

        [HttpGet] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult <List<Personage>> GetAllPersonage()
        {
            return Ok(new List<Personage>());
        }


    }
}
