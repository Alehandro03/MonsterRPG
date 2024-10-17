using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class PersonageController : Controller
    {
        [HttpGet("{id}")] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult<PersonageModel>GetPersonageById(int id)
        {
            //Если не нашли то
            return NotFound($"Персонаж{id} не найден");

            //если нашли то

            return Ok(new PersonageModel());
        }

        [HttpGet] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult <List<PersonageModel>> GetAllPersonage()
        {
            return Ok(new List<PersonageModel>());
        }

        [HttpPut]
        public ActionResult UpdatePersonage(PersonageModel personage)
        {
            return Ok($"{personage} - was update!");
        }

        [HttpPut("{id}")]
        public ActionResult SoftDeletePersonage(int id)
        {
            return Ok("Personage was deleted!");
        }

        [HttpDelete]
        public ActionResult DeletePersonage(int id)
        {
            return Ok("Personage real deleted!");
        }

    }
}
