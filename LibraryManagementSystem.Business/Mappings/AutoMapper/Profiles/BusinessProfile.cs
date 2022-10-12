using AutoMapper;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile:Profile
    {
        public BusinessProfile()
        {
            CreateMap<Book,Book>();
            CreateMap<Book, BookDetails>().ReverseMap();

            CreateMap<Author, Author>();
          
            CreateMap<Language, Language>();

            CreateMap<Publisher, Publisher>();

            CreateMap<BookRezervation, BookReservationDetails>();
            CreateMap<BookRezervation, BookRezervation>();

            CreateMap<User, User>();

            CreateMap<Category, Category>();

            CreateMap<Role, Role>();
            CreateMap<Member, Member>();



        }
    }
}
