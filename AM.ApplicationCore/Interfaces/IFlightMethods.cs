using AM.ApplicationCore.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public List<DateTime> GetFlightDates(string Destination);
        public void GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverage(string destination);

        public IEnumerable<Flight> OrderedDurationFlights();
        //public IEnumerable<Traveller> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights();
    }
}
