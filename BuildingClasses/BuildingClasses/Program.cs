using BuildingClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer();
            //SET block
            cust.Name = "Dan Wahlin";
            cust.Age = 24;
            cust.City = "Ottawa";

            //GET block
            Console.WriteLine(cust.Name);

            //Call Methods
            var details = cust.GetDetails();
            Console.WriteLine(details);

            var cust2 = new Customer("Fred", "Phoenix", 55);
            Console.WriteLine(cust2.GetDetails());

            Console.ReadLine();
        }
    }
}
