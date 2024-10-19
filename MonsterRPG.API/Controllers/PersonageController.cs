using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MonsterRPG.API.Models;
using MonsterRPG.API.Models.InputModels;
using MonsterRPG.API.Models.OutputModels;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class PersonageController : Controller
    {
        // api/prsonage/2
        [HttpGet("{id}")] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult<PersonageOutputModel> GetPersonageById(int id)
        {
            //Если не нашли то
            return NotFound($"Персонаж{id} не найден");

            //если нашли то

            return Ok(new PersonageModel());
        }
        //api/personage
        [HttpGet] // Прописываем в HTTP, рут для точного определения метода, в случае нескольких одинаковых запросах
        public ActionResult <List<PersonageSimpleOutputModel>> GetAllPersonage()
        {
            return Ok(new List<PersonageModel>());
        }
        //api/personage
        [HttpPut]
        public ActionResult<PersonageOutputModel> UpdatePersonage([FromBody] PersonageUpdateInputModel personage)
        {
            return Ok($"{personage.Name} - was update!");
        }
        // api/prsonage/2
        [HttpPut("{id}")]
        public ActionResult<PersonageOutputModel> SoftDeletePersonage(int id)
        {
            return Ok("Personage was deleted!");
        }
        // api/prsonage/2
        [HttpDelete("{id}")]
        public ActionResult DeletePersonage(int id)
        {
            return NoContent();
        }

    }
}
