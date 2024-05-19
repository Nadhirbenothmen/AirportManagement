using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Flight
    {
        public string Airline { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        [ForeignKey ("MyPlane")]
        public int Planefk { get; set; }

        public virtual Plane MyPlane { get; set; } //propriete de navigation 
        public string Pilot {  get; set; }

        //public ICollection<Passenger> ListPassenger { get; set; }
        public virtual ICollection<Ticket> ListTicket { get; set; }
        public override string ToString()
        {
            return "la destination est :" + Destination +
                    "la date du vol est :" + FlightDate +
                    "duree estimee : " + EstimatedDuration;
         }
}
}
