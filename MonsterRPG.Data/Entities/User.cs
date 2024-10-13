using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Data.Entities
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        public int IpTelegram {  get; set; }

        public string FirstName { get; set; }

        public string LastName {  get; set; }

        public string NickName { get; set; }

        public virtual Personage Personage { get; set; }
    }
}
