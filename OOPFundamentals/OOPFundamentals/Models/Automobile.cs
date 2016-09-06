using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.Models
{
    public abstract class Automobile
    {
        //Concrete members
        //prop (tab + tab)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public abstract decimal GetPrice();
    }
}
