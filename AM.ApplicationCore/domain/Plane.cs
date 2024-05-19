using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public enum PlaneType { Boing, Airbus}
    public class Plane
    {
        [Range (0 , int.MaxValue)] //un entier positive /range pour intervalle
        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> ListFlight { get; set;}
        public override string ToString()
        {
            return "la Capacité est :" + Capacity +"\n"+
                    "l'identifiant est :" + PlaneId + "\n" +
                    "la date de fabrication :" + ManufactureDate;
        }
       /* public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity= capacity;
            this.ManufactureDate= date;
            this.PlaneType= pt;
        }
        public Plane()
        {
        }*/
    }
}
