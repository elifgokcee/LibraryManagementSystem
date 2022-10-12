using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.MVCWebUI.Controllers
{
    public class LanguageController : Controller
    {
        private LanguageService _languageService;
            public LanguageController(LanguageService languageService)
        {
                _languageService=languageService;   
        }     
        // GET: Language
        public ActionResult Index()
        {
            var model = new LanguageListViewModel
            {
                Languages = _languageService.GetAll()
            };
            return View(model);
        }
    }
}