using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var mgr = new Manager();
            mgr.Age = 45;
            mgr.City = "Ottawa";
            mgr.Name = "Ron";

            var desc = mgr.GetDescription();
            Console.WriteLine(desc);
            Console.ReadLine();
        }
    }
}
