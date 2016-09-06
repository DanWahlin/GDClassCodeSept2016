using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFundamentals.Models;

namespace OOPFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var total = car.GetPrice();
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
