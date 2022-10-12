using AutoMapper;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.Concrete
{
    public class BookRezervationManager : IBookRezervationService
    {
        private IBookRezervationDal _bookRezervationDal;
        private BookService _service;
        private readonly IMapper _mapper;
        public BookRezervationManager(IBookRezervationDal bookRezervationDal, BookService service,IMapper imapper)
        {
            _bookRezervationDal = bookRezervationDal;   
            _service=service; 
            _mapper=imapper;    

        }
        public BookReservationDetails GetBookReservationDetailsById(int id)
        {var bookReservationDetails=_mapper.Map<BookReservationDetails>(_bookRezervationDal.GetBookReservationDetailsById(id));
            return bookReservationDetails;
        }
        
        public BookRezervation Add(BookRezervation entity)
        {
         
            if (IsReservationNumberInUse(entity.RezervationNumber)&&_service.GetById(entity.BookID).IsRezerved==0)
            {
                _service.MakeRezerve(entity.BookID);
                var addAuthor = _mapper.Map<BookRezervation>(_bookRezervationDal.Add(entity));
                return addAuthor;
                
                
            }
            else return null;
        }
       

        public void Dead(int Id)
        {
            var result = _bookRezervationDal.Get(x => x.Id == Id);
            if (result!=null)
            {
                result.IsActive = 0;
                result.DeadDate = DateTime.Now;
                _bookRezervationDal.Update(result);


            }
        }

        public void Delete(BookRezervation entity)
        {
           _bookRezervationDal.Delete(entity);  
          
        }
     

        public void DeleteByBookId(int bookId)
        {
           List<BookRezervation> reserveList= _bookRezervationDal.GetList(x => x.BookID == bookId);
            foreach (var reservation in reserveList) {
                Delete(reservation);
            }
           
        }

        public BookReservationDetails GetActiveReservationByBookId(int bookId)
        {
            return _bookRezervationDal.GetBookReservationDetailsByBookId(bookId);   
        }
      public BookRezervation GetBookRezervationByBookId(int bookId) {

            return _bookRezervationDal.Get(x=>x.BookID==bookId);
        }

        //1 active 0 not 
        public List<BookReservationDetails> GetActiverezervations()
        {
            return _bookRezervationDal.GetBookReservationDetails().Where(x=>x.IsActive==1).ToList();
        }

        public List<BookRezervation> GetAll()
        {
            return _bookRezervationDal.GetList();
        }

        public List<BookReservationDetails> GetBookReservationDetails()
        {
            var allBookReservations = _mapper.Map<List<BookReservationDetails>>(_bookRezervationDal.GetBookReservationDetails());
            return allBookReservations;
        }

        public List<BookReservationDetails> GetBookReservationDetailsByReserveNumber(int reservationNumber,int i=1)
        {

            return _bookRezervationDal.GetBookReservationDetails().Where(x=>x.RezervationNumber.ToString().Contains(reservationNumber.ToString())&&x.IsActive==1).ToList();
        }
        public List<BookReservationDetails> GetallBookReservationDetailsByReserveNumber(int reservationNumber)
        {

            return _bookRezervationDal.GetBookReservationDetailsByReserveNumber(reservationNumber,0);
        }
        public BookRezervation GetById(int id)
        {
            return _bookRezervationDal.Get(x=>x.BookID==id);
        }

        public bool IsReservationNumberInUse(int number)
        {
             var result =_bookRezervationDal.Get(x=>x.RezervationNumber==number);
            if (result==null)
            {
                return true;

            }
            return false;
        }

        public BookRezervation Update(BookRezervation entity)
        {
           return _bookRezervationDal.Update(entity);
        }

        public BookRezervation GetBookReservationByBookId(int bookId)
        {
            return _bookRezervationDal.Get(x => x.BookID == bookId&&x.IsActive==1);
        }

        public List<BookRezervation> GetBookRezervationByMemberId(int memberId)
        {
            var allBookReservations =
                _mapper.Map<List<BookRezervation>>(_bookRezervationDal.GetList(x=>x.RezervePersonId==memberId));
            return allBookReservations;
        }
    }
}
