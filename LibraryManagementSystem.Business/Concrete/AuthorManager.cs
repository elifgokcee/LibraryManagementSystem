
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Core.Aspects.ValidationAspects;
using LibraryManagementSystem.Business.ValidationRules;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using AutoMapper;

namespace LibraryManagementSystem.Business.Concrete
{
    public class AuthorManager : AuthorService
    {
        private IAuthorDal _authorDal;
        private readonly IMapper _iMapper;
        public AuthorManager(IAuthorDal authorDal,IMapper imapper)
        {
            _iMapper= imapper;  
            _authorDal = authorDal; 
        }
        [FluentValidationAspect(typeof(AuthorValidator))]
        public Author Add(Author author)
        {
            var addAuthor = _iMapper.Map<Author>(_authorDal.Add(author));
            return addAuthor;
        }

        public void Delete(Author author)
        {
          
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            var authors= _iMapper.Map<List<Author>>(_authorDal.GetList());
            return authors;
        }

        public Author GetById(int id)
        {
            var author = _iMapper.Map<Author>(_authorDal.Get(x=>x.AuthorID==id));
            return author;
        }

        public string GetNameAndSurName(int id)
        {
            return GetById(id).AuthorName + "  " + GetById(id).AuthorSurName;


        }

        public bool IsAlreadyBeen(string name, string surname)
        {
          var result= _authorDal.Get(x=>x.AuthorName+x.AuthorSurName.Trim().ToLower()==name+surname.Trim().ToLower());
            if (result != null) return false;
            else return true;
        }
        [FluentValidationAspect(typeof(BookValidator))]
        public Author Update(Author entity)
        {
            return _authorDal.Update(entity);
        }
    }
}
