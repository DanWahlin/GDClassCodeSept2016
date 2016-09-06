using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.Models
{
    public class Car : Automobile
    {
        public override decimal GetPrice()
        {
            return 30000.00M;
        }

        //This is an overload
        //public decimal GetPrice(decimal taxRate)
        //{
        //    return 0M;
        //}
    }
}
