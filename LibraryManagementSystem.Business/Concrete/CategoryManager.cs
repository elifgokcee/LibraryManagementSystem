using AutoMapper;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Concrete
{
    public class CategoryManager : CategoryService
    {
        private ICategoryDal _categoryDal;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal,IMapper mapper)
        {
            _mapper = mapper;
            _categoryDal = categoryDal;
        }
    
        public Category Add(Category category)
        {
           var addedCategory=_mapper.Map<Category>(_categoryDal.Add(category));
            return addedCategory;
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            var categories = _mapper.Map<List<Category>>(_categoryDal.GetList());
            return categories;
        }

        public Category GetById(int id)
        {
            var category = _mapper.Map<Category>(_categoryDal.Get(x=>x.CategoryID==id));
            return category;
        }

        public Category Update(Category category)
        {
          return _categoryDal.Update(category);
        }
    }
}
