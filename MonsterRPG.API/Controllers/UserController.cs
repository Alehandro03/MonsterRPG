﻿using Microsoft.AspNetCore.Mvc;
using MonsterRPG.API.Models.InputModels;
using MonsterRPG.API.Models.OutputModels;
using MonsterRPG.Buiness;
using MonsterRPG.Buiness.Models;

namespace MonsterRPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class UserController : Controller
    {
        //api/user 
        [HttpPost]
        public ActionResult<UserOutputModel> AddUser(UserInsertInputModel model)
        {
            return Ok("Успешно добавлен");
        }
        // api/user/2
        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {   
            return NoContent();
        }
        // api/user/2
        [HttpGet("{id}")]
        public ActionResult<UserModel> GetUserById(int id)
        {
            //Если не нашли то
            return NotFound($"User{id} was noy found");

            //если нашли то

            //return Ok(new User());
        }
        // api/user
        [HttpGet]
        public ActionResult<List<UserModel>> GetUsers()
        {
            return Ok();
        }
        // api/user/2
        [HttpPut("{id}")]
        public ActionResult<UserOutputModel> UpdateUser(int id, UserUpdateInputModel model)
        {
            return Ok("Успешно изменен");
        }
    }

}
