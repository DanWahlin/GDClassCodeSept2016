using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.Models
{
    public class SportsCar : Car
    {
        const decimal taxRate = .08M;

        public override decimal GetPrice()
        {
            return base.GetPrice() * (100 * taxRate);
        }
    }
}
