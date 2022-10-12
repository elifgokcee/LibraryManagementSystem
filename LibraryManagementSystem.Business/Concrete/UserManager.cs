using LibraryManagementSystem.Business.ValidationRules;

using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Core.Aspects.ValidationAspects;
using LibraryManagamentSystem.Core.Utilities.Auth;
using AutoMapper;

namespace LibraryManagementSystem.Business.Concrete
{
    public class UserManager : UserService
    {
        private IUserDal _userDal;
        private IMapper _mapper;
        public UserManager(IUserDal userDal,IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;   
        }

        [FluentValidationAspect(typeof(UserValidator))]
        public User Add(User user)
        {
            user.Password = user.Password;
           return _userDal.Add(user);    
        }

        public void Delete(User entity)
        {
           _userDal.Delete(entity);
           
        }

        public List<User> GetAll()
        {
            var users=_mapper.Map<List<User>>(_userDal.GetList());
            return users;
        }

        public User GetById(int id)
        {
            var user = _mapper.Map<User>(_userDal.Get(x=>x.UserID==id));
            return user;

        }

        public bool Login(string userName,string password)

        {
          
            User user = _userDal.Get(x => x.UserName == userName);
           if(user!=null)
            {

                var result = VerifyUser.VerifyHashedPassword(user.Password, password);
                if (result == true)
                { return true; }
                return false;   
                
            }
            else
            {
                return false;
            }   
        }
        public string GetRole(string userName,string password)
        {

            User user = _userDal.Get(x => x.UserName == userName);
            if (user != null&& VerifyUser.VerifyHashedPassword(user.Password, password))
            {

                return user.Role;

            }
            return null;
        }

        public User Update(User entity)
        {
           return _userDal.Update(entity);
        }

        public bool IsUserNameAlredyBeen(string username)
        {
            bool sonuc = _userDal.Get(x => x.UserName == username) == null 
               ?   true
               :    false;
            return sonuc;
        }

        public User GetUser(string userName, string password)
        {

            User user = _userDal.Get(x => x.UserName == userName);
            if (user != null && VerifyUser.VerifyHashedPassword(user.Password, password))
            {

                return user;

            }
            return null;
        }
    }
}
