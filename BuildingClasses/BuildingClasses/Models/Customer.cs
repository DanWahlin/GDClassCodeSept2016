using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingClasses.Models
{
    public class Customer
    {
        //Constructors
        //ctor (tab + tab)
        public Customer()
        {
            
        }

        public Customer(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }

        //Field
        string _name;

        //Property (gateway or filters - like a door with a screen)
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 10)
                {
                    _name = value;
                }
                else
                {
                    throw new ApplicationException("Name is too long!");
                }
            }
        }

        //propfull (tab + tab)
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        //Method (function)
        public string GetDetails()
        {
            return Name + " " + City;
        }

        //Method (subroutine)
        //I'd use the property to set this
        public void SetCity(string city)
        {
            City = city;
        }

        //prop (tab + tab)
        //If you want logic, use propfull (tab + tab)
        public int Age { get; set; }


    }
}
