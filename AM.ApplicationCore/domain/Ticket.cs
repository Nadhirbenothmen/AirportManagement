using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Ticket
    {
        public double Prix { get; set; }
        public int Siege { get; set; }
        public bool VIP { get; set;}
        public virtual Flight MyFlight { get; set; }
        public virtual Passenger MyPassenger { get; set; }

        [ForeignKey("MyFlight")] // la propriété de navigation 
        public int FlightFK { get; set; }

        [ForeignKey("Mypassenger")] 
        public string PassengerFK { get; set;}
    }
}
