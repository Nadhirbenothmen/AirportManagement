using AM.ApplicationCore.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName (this Passenger passenger)
        {
            passenger.FullName.FirstName = passenger.FullName.FirstName[0].ToString().ToUpper()+passenger.FullName.FirstName.Substring(1);

            passenger.FullName.LastName = passenger.FullName.LastName[0].ToString().ToUpper()+ passenger.FullName.LastName.ToString ().Substring(1);


        }
    }
}
