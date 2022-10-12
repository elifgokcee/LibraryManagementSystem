using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagementSystem.WebAPI.Controllers
{
    public class AuthorsController : ApiController
    {
        private AuthorService _authorService;
        public AuthorsController(AuthorService author)
        {
            _authorService = author;    

        }
        public List<Author> Get()
        {
            return _authorService.GetAll(); 
        }
        public Author GetById(int id)
        {
            return _authorService.GetById(id);  
        }
        [HttpPost]
        public Author Post([FromBody]Author author)
        {
            return _authorService.Add(author);
        }
        [HttpPut]
        public Author Put([FromBody] Author author)
        {
            return _authorService.Update(author);
        }
        [HttpDelete]
        public void Delete([FromBody] Author author)
        {
             _authorService.Delete(author);
        }
    }
}
