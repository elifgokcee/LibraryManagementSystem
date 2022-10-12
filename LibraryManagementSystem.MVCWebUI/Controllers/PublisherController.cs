using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class PublisherController : Controller
    {
        // GET: Publisher
        private PublisherService _publisherService;
        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
    
        public ActionResult Index()
        {
            var model = new PublisherListViewModel
            {
                Publishers=_publisherService.GetAll()
            };
            return View(model);
        }
    }
}