using System;
using oop_lesson_4_parking.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();


            carpark.listOfCustomers.Add(new Customer("a", 2));
            carpark.listOfCustomers.Add(new Customer("b", 3));
            carpark.listOfCustomers.Add(new Customer("c", 6));
            carpark.listOfCustomers.Add(new Customer("d", 8));
            carpark.listOfCustomers.Add(new Customer("e", 9));
            carpark.listOfCustomers.Add(new Customer("f", 10));

            carpark.CalculateCharges();

            Customer customer = new Customer("g", 7);
            CarParkCharge carparkcharge = new CarParkCharge();
            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());

        }
    }
}
