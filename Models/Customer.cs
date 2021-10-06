using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class Customer
    {
        public string carRegistration { get; set; }
        public int hoursParked { get; set; }
        public Customer(string _carRegistration,int _hoursParked)
        {
            Console.WriteLine("I am the customer()");
            hoursParked = _hoursParked;
            carRegistration = _carRegistration;
        }
        public override string ToString()
        {
            return "I am the customer()";
        }
    }
}
