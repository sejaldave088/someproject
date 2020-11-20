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
            Child cd = new Child();
            Console.WriteLine("the name is:", ad.FirstName);
            Console.WriteLine("the name is:", ad.LastName);
            polymor[] a1 = new polymor[] { ad,cd };

        }
        public interface polymor
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void Print()
            {
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
            }

        }
        public class Adult : polymor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void Print()
            {
                // Code to draw a circle...
                Console.WriteLine("display a name");

            }
        }
            public class Child : polymor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void Print()
            {
                // Code to draw a circle...
                Console.WriteLine("display a name");

            }
        }
    }
}
