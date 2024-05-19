using AM.ApplicationCore.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight : IService<Flight>

    {
        //IEnumerable = Ilist
        public IList<IGrouping<DateTime, Flight>> GetFlights(int n);
        public IEnumerable<Staff> GetStaff(int flightId);
        public IEnumerable<Flight> SortFlights();
    }
}
