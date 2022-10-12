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
    public class LanguageManager : LanguageService
    {
        private ILanguageDal _languageDal;
        private IMapper _imapper;
        public LanguageManager(ILanguageDal languageDal,IMapper imapper)
        {
            this._languageDal = languageDal;
            _imapper = imapper; 
        }
    
        public Language Add(Language entity)
        {
            return _languageDal.Add(entity);
        }

        public void Delete(Language language)
        {
           _languageDal.Delete(language);
        }

        public List<Language> GetAll()
        {
            var languages = _imapper.Map<List<Language>>(_languageDal.GetList());
            return languages;
        }

        public Language GetById(int id)
        {
            var language = _imapper.Map<Language>(_languageDal.Get(x=>x.LanguageID==id));
            return language;
        }

        public bool IsAlreadyBeen(string languageName)
        {
           var result= _languageDal.Get(x=>x.LanguageName==languageName);
            if (result != null) return false;
            else return true;
        }

        public Language Update(Language language)
        {
           return _languageDal.Update(language);
        }
    }
}
