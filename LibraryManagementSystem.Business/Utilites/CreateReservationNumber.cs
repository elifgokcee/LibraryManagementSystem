using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Utilites
{
    public static class CreateReservationNumber
    {
        
        public static int CreateReservation(IBookRezervationService service)
        {
            Random random = new Random();
            int number=random.Next(100000,999999);
            if (service.IsReservationNumberInUse(number)) {
                return number;  
            }
            else
            {
                number = random.Next(100000, 999999);

            }

            return number;

        }
    }
}
