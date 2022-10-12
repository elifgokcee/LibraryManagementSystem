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
    public class PublisherManager : PublisherService
    {
        private IPublisherDal _publisherDal;
        private IMapper _mapper;
        public PublisherManager(IPublisherDal publisherDal,IMapper mapper)
        {
            _publisherDal = publisherDal;
            _mapper = mapper;   
        }
    
        public Publisher Add(Publisher entity)
        {
           return _publisherDal.Add(entity);
        }

        public void Delete(Publisher entity)
        {
           _publisherDal.Delete(entity);
        }

        public List<Publisher> GetAll()
        {
            var publishers = _mapper.Map<List<Publisher>>(_publisherDal.GetList());
            return publishers;

        }

        public Publisher GetById(int id)
        {

            var publisher = _mapper.Map<Publisher>(_publisherDal.Get(x=>x.PublisherID==id));
            return publisher;
        }

        public bool IsAlreadyBeen(string publisherName)
        {
            var result = _publisherDal.Get(x=>x.PublisherName==publisherName);
            if (result != null) return false;
            else return true;
        }

        public Publisher Update(Publisher publisher)
        {
            return _publisherDal.Update(publisher);
        }
    }
}
