using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService=userService;
        }
        public ActionResult Index()
        {
            var model = new UserListViewModel
            {
                Users = _userService.GetAll()
            };
            return View(model);
        }
    }
}