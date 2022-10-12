using AutoMapper;
using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.Business.ServiceAdapters;

using LibraryManagamentSystem.DataAccess.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.Concrete
{
    public class MemberManager : MemberService
    {
        private IMemberDal _memberDal;
        private IMapper _mapper;
        private IKpsService _kpsService;
        private IBookRezervationService _bookRezervationService;
      
        public MemberManager(IMemberDal memberDal, IMapper mapper,IKpsService kpsService,IBookRezervationService bookRezervationService)
        {
            _memberDal = memberDal;
            _mapper = mapper;
            _kpsService = kpsService;   
            _bookRezervationService = bookRezervationService;   

        }
    
        public Member Add(Member entity)
        {
            if (_kpsService.ValidateMember(entity))
            { return _memberDal.Add(entity); }
            else
            { throw new Exception("gecersiz"); }
         
        }

        public void Delete(Member entity)
        {
            try
            {
               if(GetMemberByTCNo(entity.TcNo)!=null)
                {
                    List<BookRezervation> reserveList = _bookRezervationService.GetBookRezervationByMemberId(entity.Id);
                    IsReserveListIsnOtNullDeleteReservations(reserveList);

                    _memberDal.Delete(entity);

                }

               
            }
            catch {
                throw new Exception("gecersiz");
            }
            
        }
        public void IsReserveListIsnOtNullDeleteReservations(List<BookRezervation> reserveList)
        {
            if (reserveList.Count > 0)
            {
                {
                    foreach (var reservation in reserveList)
                    {
                        _bookRezervationService.Delete(reservation);
                    }
                }




            }
        }

        public List<Member> GetAll()
        {
            var members = _mapper.Map<List<Member>>(_memberDal.GetList());
            return members;
        }

        public Member GetById(int id)
        {
           var member= _mapper.Map<Member>(_memberDal.Get(x=>x.Id==id));
            return member;
        }

        public int GetIdByTCNo(string TcNo)
        {
            var result = GetMemberByTCNo(TcNo);

         return result==null ? 0 : result.Id;
        }

        public Member GetMemberByTCNo(string TcNo)
        {
            var result = _memberDal.Get(x => x.TcNo == TcNo);

            return result;
        }

        public bool isAlreadyBeen(string TcNo)
        {
           var result= _memberDal.Get(x=>x.TcNo==TcNo);
             return result == null ? true : false;
        }

        public Member Update(Member entity)
        {
            if (_kpsService.ValidateMember(entity))
            { return _memberDal.Update(entity); }
            else
            { throw new Exception("gecersiz"); }
           
        }
    }
}
