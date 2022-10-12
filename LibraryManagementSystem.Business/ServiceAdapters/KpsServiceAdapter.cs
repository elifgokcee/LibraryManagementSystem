
using LibraryManagamentSystem.Business.ServiceReference1;
using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateMember(Member member)
        {
            using (
            KPSPublicSoapClient client = new KPSPublicSoapClient()) 
            {
                var result = client.TCKimlikNoDogrula(

                    Convert.ToInt64(member.TcNo),
                    member.FirstName.ToUpper(),
                    member.LastName.ToUpper(),
                    member.DateOfBirth.Year


                    );
                return result; }
        }
    }
}
