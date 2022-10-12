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
    public class LanguagesController : ApiController
    {
        private LanguageService _service;
        public LanguagesController(LanguageService service)
        {
            _service = service; 
        }
        public List<Language> Get()
        {
            return _service.GetAll();
        }
        public Language GetById(int id)
        {
            return _service.GetById(id);    
        }
        [HttpPost]
        public Language Post([FromBody] Language language)
        {
            return _service.Add(language);
        }
        [HttpPut]
        public Language Put([FromBody] Language language)
        {
            return _service.Update(language);
        }
        [HttpDelete]
        public void Delete([FromBody] Language language)
        {
            _service.Delete(language);
        }
    }
}
