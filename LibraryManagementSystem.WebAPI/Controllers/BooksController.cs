using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LibraryManagementSystem.WebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private BookService _bookService;
        public BooksController(BookService service)
        {
            _bookService = service;
        }

        //public List<Book> Get()
        //{
        //    return _bookService.GetAll();
        //}
        public List<Book> Get()
        {
            return _bookService.GetAll();
        }
        public BookDetails GetById(int id)
        {
            return _bookService.GetBookDetailsById(id); 
        }

        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return _bookService.Add(book);
        }
        [HttpPut]
        public Book Put([FromBody] Book book)
        {
            return _bookService.Update(book);
        }
        [HttpDelete]
        public void Delete([FromBody] Book book)
        {
            _bookService.Delete(book);
        }


    }
}