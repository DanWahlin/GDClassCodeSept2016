using System;
using System.Collections.Generic;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int recordCount = 5;
            string[] names = new string[recordCount];
            names[0] = "Ted";
            names[1] = "Michelle";

            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }

                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
            }

            var peopleNames = new List<string>();
            peopleNames.Add("Ted");
            peopleNames.Add("Michelle");

            foreach (var name in peopleNames)
            {
                Console.WriteLine(name);
            }

            const int DEPT_ID = 5656;
            string message = "Hello World";
            int age = 50;
            var age2 = 60;
            age = 60;

            long nationalDebt = 52L;

            //Convert from long to int
            Print((int)nationalDebt);
            Print(Convert.ToInt32(nationalDebt));

            if (nationalDebt > 100)
            {
                Console.WriteLine("Too big!");
            }
            else
            {
                Console.WriteLine("Gov knows what they're doing");
            }

            switch (nationalDebt)
            {
                case 52:
                    Console.WriteLine("Some value for 52");
                    break;
                case 100:
                    Console.WriteLine("Some value for 100");
                    break;
                default:
                    Console.WriteLine("This is the default");
                    break;
            }

            //Console.WriteLine(message);
            //Console.WriteLine(age);
            //Console.WriteLine(age2);
            //Console.WriteLine(DEPT_ID);
            Console.ReadLine();
        }

        static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
