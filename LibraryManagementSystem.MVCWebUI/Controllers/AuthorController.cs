using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class AuthorController : Controller
    {
        public AuthorService _authorService;
        // GET: Author
        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService; 

        }
        public ActionResult Index()
        {
            var model = new AuthorListViewModel
            {
                Authors = _authorService.GetAll()
            };
            return View(model);
        }
    }
}