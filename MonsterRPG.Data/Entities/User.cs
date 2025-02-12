
using System.ComponentModel.DataAnnotations.Schema;


namespace MonsterRPG.Data.Entities
{
    [Table("User")]
    public class User
    {
        public int? Id { get; set; }
        public int? IpTelegram {  get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public string NickName { get; set; }
        public int Personage  { get; set; }
    }
}
