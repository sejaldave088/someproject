using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult ad = new Adult();
            ad.FirstName = "prutha";
            ad.LastName = "biho";
            Console.WriteLine("the name is:", ad.FirstName);
            Console.WriteLine("the name is:", ad.LastName);


        }
        public class Adult
        {

            public string FirstName;
            public string LastName;
            
        }
        public class Child
        {
            public string FirstName;
            public string LastName;
        }
    }
}
