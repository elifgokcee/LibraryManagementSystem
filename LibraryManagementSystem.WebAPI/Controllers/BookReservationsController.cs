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
    public class BookReservationsController : ApiController
    {
        private IBookRezervationService _service;
        public BookReservationsController(IBookRezervationService service)
        {
            _service = service; 
        }
        public List<BookReservationDetails> Get()
        {
            return _service.GetBookReservationDetails();    
        }
        public BookReservationDetails GetById(int id)
        {
            return _service.GetBookReservationDetailsById(id);
        }
        [HttpPost]
        public BookRezervation Post([FromBody] BookRezervation bookRezervation)
        {
            return _service.Add(bookRezervation);
        }
        [HttpPut]
        public BookRezervation Put([FromBody] BookRezervation bookRezervation)
        {
            return _service.Update(bookRezervation);
        }
        [HttpDelete]
        public void Delete([FromBody] BookRezervation bookRezervation)
        {
            _service.Delete(bookRezervation);
        }
    }
}
