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
    public class PublishersController : ApiController
    {
        private PublisherService _service;
        public PublishersController(PublisherService service)
        {
            _service = service;

        }
        public List<Publisher> Get()
        {
            return _service.GetAll();   
        }
        public Publisher GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public Publisher Post([FromBody] Publisher publisher)
        {
            return _service.Add(publisher);
        }
        [HttpPut]
        public Publisher Put([FromBody] Publisher publisher)
        {
            return _service.Update(publisher);
        }
        [HttpDelete]
        public void Delete([FromBody] Publisher publisher)
        {
            _service.Delete(publisher);
        }
    }
}
