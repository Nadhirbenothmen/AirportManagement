using AM.ApplicationCore.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane : IService<Plane>
    {
        public IEnumerable<Passenger> GetPassengers (Plane plane);
        public bool GetCapacity (Flight flight, int n);
        public void deleteplane();
        public IEnumerable<Traveller> GetTravellers(Plane plane, DateTime date);
        public int GetnbrTravellers (DateTime startDate , DateTime endDate);
        public void GetnbrTravellers2 (DateTime startDate , DateTime endDate);
    }
}
