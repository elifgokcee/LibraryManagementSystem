using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class BookController : Controller
    {
       private BookService _bookservice;
        public BookController(BookService bookservice)
        {
            this._bookservice = bookservice;
        }
    
        // GET: Book
        public ActionResult Index()
        {
            var model = new BookListViewModel
            {
                Books = _bookservice.GetNonReservedBooks()
            };
            return View(model);
        }
       
    }
}