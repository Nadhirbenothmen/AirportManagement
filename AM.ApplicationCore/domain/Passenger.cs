using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Passenger
    {
        //public int Id { get; set; } 
        [Display (Name = "Date of Birth")] //afficher date birth
        [DataType(DataType.DateTime)] //talaa3li calendrier
         
        public DateTime BirthDate { get; set; }

        [Key , StringLength (7)] 
        public String PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
       //ou bien [EmailAddress]
        public string EmailAddress { get; set; }


        //[MaxLength (25 , ErrorMessage = "la longeur maximale 25")]
        //[MinLength (3 , ErrorMessage = "la longeur minimale 3")]
        //public string FirstName { get; set; }

        //public string LastName { get; set; }

        [RegularExpression (@"^[0-9]{8}$")] //num contenant 8 chiffres 
        public string TelNumber { get; set;}
        //public ICollection<Flight> ListFlight { get; set; }
        public virtual ICollection<Ticket> ListTicket { get; set; }
        public override string ToString()
        {
            return "FlirstName =" +FullName.FirstName  +
                    "LastName =" + FullName.LastName +
                    "EmailAddress =" + EmailAddress;
        }
        /*public bool CheckProfile(string firstname,string lastname)
        {
            if (this.FlirstName==firstname && this.LastName==lastname)
                return true;
            else 
                return false;
        }
        public bool CheckProfile(string firstname, string lastname,string email)
        {
            return(this.FlirstName==firstname && this.LastName==lastname && this.EmailAddress==email);
        }*/
        public bool CheckProfile(string firstname, string lastname, string email = null)
        {
            if (email==null)
                return (FullName.FirstName == firstname && FullName.LastName == lastname);
            else
                return (FullName.FirstName == firstname && FullName.LastName == lastname && this.EmailAddress == email);
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("im a passenger");
        }
        public FullName FullName  { get; set;}
    }
}
