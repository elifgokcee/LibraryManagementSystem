using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
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
    public class RolesController : ApiController
    {

        private RoleService _roleService;
        public RolesController(RoleService roleService)
        {
            _roleService = roleService; 
        }
        public List<Role> Get()
        {
            return _roleService.GetAll();
        }
        public Role GetById(int id)
        {
            return _roleService.GetById(id);    
        }
        [HttpPost]
        public Role Post([FromBody] Role role)
        {
            return _roleService.Add(role);
        }
        [HttpPut]
        public Role Put([FromBody] Role role)
        {
            return _roleService.Update(role);
        }
        [HttpDelete]
        public void Delete([FromBody] Role role)
        {
            _roleService.Delete(role);
        }
    }
}
