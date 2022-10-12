using AutoMapper;
using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.DataAccess.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.Concrete
{
    public class RoleManager : RoleService
    {
        private IRoleDal _roleDal;
        private IMapper _mapper;
        public RoleManager(IRoleDal roleDal,IMapper mapper)
        {
            _roleDal = roleDal;
            _mapper = mapper;   
        }
    
        public Role Add(Role entity)
        {
          return  _roleDal.Add(entity);   
        }

        public void Delete(Role entity)
        {
            _roleDal.Delete(entity);
        }
        public List<Role> GetAll()
        {
            var roles = _mapper.Map<List<Role>>(_roleDal.GetList());
            return roles;
        }

        public Role GetById(int id)
        {
            var role = _mapper.Map<Role>(_roleDal.Get(x=>x.Id==id));
            return role;

        }

        public Role Update(Role entity)
        {
           return _roleDal.Update(entity);  
        }
    }
}
