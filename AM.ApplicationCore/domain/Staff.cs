using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }

        [DataType (DataType.Currency)] //el3omla de salaire 
        public Double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + "le salaire est :" + Salary;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("i am a staff member");
        }
    }
}
