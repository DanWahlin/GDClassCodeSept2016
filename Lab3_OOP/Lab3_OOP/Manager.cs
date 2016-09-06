using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    public class Manager : Person
    {
        public override string GetDescription()
        {
            //Partial override since we preserve what the
            //base class method does
            return "The Manager! " + base.GetDescription();
        }
    }
}
