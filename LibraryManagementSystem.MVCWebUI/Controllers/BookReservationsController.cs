using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.MVCWebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class BookReservationsController : Controller
    {
        private IBookRezervationService _bookReseravtionService;
        public BookReservationsController(IBookRezervationService bookReseravtionService)
        {
            this._bookReseravtionService = bookReseravtionService;
        }

        // GET: Book
        public ActionResult Index()
        {
            var model = new BookReservationListViewModel
            {
                BookReservations = _bookReseravtionService.GetActiverezervations()
            };
            return View(model);
        }

    }
}
