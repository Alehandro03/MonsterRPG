﻿using MonsterRPG.Data.Entities;

namespace MonsterRPG.API.Models
{
    public class UserInsertInputModel : UserUpdateInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Personage { get; set; }
    }
}
