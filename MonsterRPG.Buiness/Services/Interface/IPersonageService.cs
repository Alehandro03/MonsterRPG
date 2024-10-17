using MonsterRPG.Buiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Services.Interface
{
    public interface IPersonageService
    {
        PersonageModel AddPersonage(PersonageModel pers);
        void ChangePersonage(int id, PersonageModel pers);
        PersonageModel GetPersonageById(int id);
        List<PersonageModel> GetAllPersonage();
        PersonageModel DeletePersonage(PersonageModel user);
    }
}
