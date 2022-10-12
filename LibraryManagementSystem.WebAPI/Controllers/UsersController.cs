using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagementSystem.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService; 
        }
        public List<User> Get()
        {
            return _userService.GetAll();

        }
        public User GetById(int id)
        {
            return _userService.GetById(id);

        }
        [HttpPost]
        public User Post([FromBody] User user)
        {
            return _userService.Add(user);
        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _userService.Update(user);
        }
        [HttpDelete]
        public void Delete([FromBody] User user)
        {
            _userService.Delete(user);
        }

    }
}
