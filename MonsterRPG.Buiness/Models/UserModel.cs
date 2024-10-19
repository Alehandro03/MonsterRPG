using MonsterRPG.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness.Models
{
    public class UserModel
    {
        public int? Id { get; set; }
        public int? IpTelegram { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public  int Personage { get; set; }
    }
}
