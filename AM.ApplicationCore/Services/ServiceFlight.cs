using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
    {
        IUnitOfWork unitOfWork;

        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<IGrouping<DateTime, Flight>> GetFlights(int n)
        {
            return unitOfWork.Repository<Plane>().GetAll()
                .OrderByDescending(p => p.PlaneId)
                .Take(n)
                .SelectMany(p => p.ListFlight)
                .GroupBy(f => f.FlightDate)
                .ToList();
        }
        public IEnumerable<Staff> GetStaff(int flightId)
        {

            return GetById(flightId).ListTicket
                .Select(T => T.MyPassenger)
                .OfType<Staff>();
        }
        public IEnumerable<Flight> SortFlights()
        {
            return GetAll().OrderByDescending(f => f.FlightDate);
        }
    }
}


