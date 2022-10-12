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
    public class CategoriesController : ApiController
    {
        private CategoryService _categoryService;
        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService; 
                
        }
        public List<Category> Get()
        {
            return _categoryService.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }
        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            return _categoryService.Add(category);
        }
        [HttpPut]
        public Category Put([FromBody] Category category)
        {
            return _categoryService.Update(category);
        }
        [HttpDelete]
        public void Delete([FromBody] Category category)
        {
            _categoryService.Delete(category);
        }


    }
}
