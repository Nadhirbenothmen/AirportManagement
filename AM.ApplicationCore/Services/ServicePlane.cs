using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane

    {
        IUnitOfWork unitOfWork;
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void deleteplane()
        {
            foreach (Plane plane in GetAll().Where(p => (DateTime.Now - p.ManufactureDate).TotalDays > 365 * 10))
            {
                Delete(plane);
            };
        }

        public bool GetCapacity(Flight flight, int n)
        {
            int capacity = GetById(flight.MyPlane.PlaneId).Capacity;
            int nbrpassenger = flight.ListTicket.Count;
            return capacity > nbrpassenger + n;
        }

        public int GetnbrTravellers(DateTime startDate, DateTime endDate)
        {
            return unitOfWork.Repository<Flight>()
                .GetMany(f => f.FlightDate > startDate && f.FlightDate < endDate)
                .SelectMany(f => f.ListTicket)
                .Select(t => t.MyPassenger)
                .OfType<Traveller>().Count();
        }

        public void GetnbrTravellers2(DateTime startDate, DateTime endDate)
        {
            var req = unitOfWork.Repository<Flight>()
                .GetMany(f => f.FlightDate > startDate && f.FlightDate < endDate)
                .SelectMany(f => f.ListTicket)
                .GroupBy(t => t.MyFlight.FlightDate)
                .Select(t => new { Group = t.Key, Nbr = t.Count() });
            foreach (var item in req)
            {
                Console.WriteLine("la date de vol = " + item.Group +
                                   "le nombre de voyageur = " + item.Nbr);
            }

        }

        public IEnumerable<Passenger> GetPassengers(Plane plane)
        {
            return plane.ListFlight.SelectMany(f => f.ListTicket.Select(t => t.MyPassenger));
        }

        public IEnumerable<Traveller> GetTravellers(Plane plane, DateTime date)
        {
            return unitOfWork.Repository<Flight>()
               .GetMany(f => f.FlightDate == date && f.MyPlane.PlaneId == plane.PlaneId)
               .SelectMany(f => f.ListTicket)
               .Select(T => T.MyPassenger)
               .OfType<Traveller>();
        }
    }
}
