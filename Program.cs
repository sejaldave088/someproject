using System;

//program 1: Kudvenkat Csharp Tutorials

//(1) A namespace:
// is a collectioin of classes.


//using System: System is a namespace use for organising our codes and it is 
//a collection various software artifacsts such as:

// - classes
// - Interface
// - structs (structures)
// - enums and
// - delegates
// - other namespaces (a namespace can contain other namespaces)
//that can be used by our program. 


//For example, 

//to print a message on the screen, we use the Console method(or function), 
//this method is within the System namespace. 
//The fully qualify name for the Console method is System.Console.***




//(2) Class:
// Any piece of code we create should recide in a class. 

//i.  Function(or Method): 

// Function or method resides wthin a class and they are the ones that really do the work.
// A function should have access modifiers. Will  consider that in great details shortly.

//ii. Main() method:
//Within a class, the main method is the entry point to your application.
//If a class have hundreds of method, the program will start its excution from the main method.
//Every console application should have a main method which tells the point of execution of the class.


class Program
{

    // Kudvenkat 01 - Introduction:  Completed.

    //static void Main1()
    //{
    //    Console.WriteLine("Welcome to C Sharp Training!");
    //}

    //static void Main()
    //    {
    //        Console.WriteLine("Hello World!");
    //        Main1();

    //    }



    // Through Kudvenkt Insight for Class Assignment 01: Revert.
    //Class Assignment1   -----------Get more information ------------------------
    //public static int Cal(int x, int y)
    //{
    //    int result = x + y;
    //    return result;
    //}

    //static void Main()
    //{
    //    Console.WriteLine("Hello World!");
    //    Main();
    //}




    // Kudvenkat 02 - Reading and writing to a console: Completed.

    //public static void ReadWriteLine()
    //{
    //    Console.WriteLine("Please Enter your first name: ");
    //    string Firstname = Console.ReadLine();

    //    Console.WriteLine("Please Enter your last name: ");
    //    string Lastname = Console.ReadLine();



    //    Console.WriteLine("Hello {0}, {1}", Firstname, Lastname);  //using place holder



    //console.WriteLine("Hello " + username);  //using contatenation
    //}

    //static void Main()
    //{
    //    Console.WriteLine("hello world!");
    //    ReadWriteLine();

    //}





    // Kudvenkat 03 and 04 - Built-in types:  Completed
    //msdn.microsoft.com/en-us/libary/h21280bw.aspx      <----- link

    //1. Built in types in C# include:

    // 1. Boolean Types:     Only uses true or flase

    // 2. Integral Types: 

    //i.   sbyte,  
    //ii.  byte,  
    //iii. short,  
    //iv.  int, 
    //v.   unit, 
    //vi.  long, 
    //vii. ulong
    //viii.char

    // 3. Floating Types:  float and double
    // 4. Decimal Types: 
    // 5. String Types:


    //Verbatim literal

    //1. The "\" symbol can act as escape sequence when writing. E.g, "\"John"
    //2. The @ symbol before a string, all the escape sequences are no longer treated as escape sequence.
    //2. 

    //public static void Builtins()
    //{
    //    //Determine the minimum and maximum values of a variable.
    //    Console.WriteLine("Min = {0}, Max = {1}", int.MinValue, int.MaxValue);

    //    //verbatim literal
    //    Console.WriteLine("Without Verbatim Literal: C:\\Users\\John Ameh\\source\\repos\\kudvenkat\\kudvenkat\\bin\\Debug\\netcoreapp3.1");
    //    Console.WriteLine(@"With Verbatim Literal: C:\Users\John Ameh\source\repos\kudvenkat\kudvenkat\bin\\Debug\netcoreapp3.1");

    //}

    //static void Main()
    //{
    //    //Console.WriteLine("hello world!");
    //    Builtins();
    //}




// Kudvenkat05 - Common Operators in C#

//1. Assignment Operator
//   Equal: = 

//2. Arithmetic Operators like:
//  i.Plus: +,
//  ii.Minus: -, 
//  iii.Multiplaction: *, 
//  iv.Division: /, 
//   v.Modulus: %

//3.Comparisoin Operators like:

//  i.Double Equal: ==,
//  ii.  Not Equal: !=,
//  iii. Greater:   >,
//  iv.Greater than or Equal to: >=, 
//   v.Less than: <
//  vi.Less than or Equal to: <=
  
//4. Conditional Operators like

//  i.and : &&,
// ii.or :  ||,
//iii.Tenary Operator ?:
//iv.Null Coalescing Operator ??



    //static void CommonOperators()
    //{
    //    int Numerator = 10;
    //    int Denominator = 2;
    //    int fnum = 10;
    //    int snum = 20;



    //    //(a) Testing the "/" and the "%" operators
    //    int Result = Numerator / Denominator;
    //    int Quotient = Numerator % Denominator;

    //    Console.WriteLine("Division = {0}", Result);
    //    Console.WriteLine("Quotient = {0}", Quotient);


    

    //    //(b) comparison
    //    if (fnum == 10 && snum == 20)
    //    {
    //        Console.WriteLine("Hello");
    //    }





    //    //(c) Tenary Operator
    //    {
    //        //i. Long way of writing
    //        bool fnum10;

    //        if (fnum == 10)
    //        {
    //            fnum10 = true;
    //        }
    //        else
    //        {
    //            fnum10 = false;
    //        }
    //        Console.WriteLine(" Long way of doing things: Number == 10 is {0}", fnum);



    //        //ii. Short way of writing
    //        bool fnumCase2 = fnum == 10 ? true : false;
    //        Console.WriteLine("Tenary way of doing things: Number == 10 is {0}", fnumCase2);
    //    }
    //}


    static void Main()
    {
         AddNum();
    }




    // Coward
    static int n;
    static void AddNum()
    {
        int i;
        int sum = 0;
        
        int NbrOfItems;


        Console.Write("\n\n");
        Console.Write("1. This program add a series of numbers together. \n2. To add 3 different numbers; e.g, a+b+c, enter 3.");
        Console.Write("\n\n----------------------------------------------");


        Console.Write("\n");
        Console.Write("3. How many numbers do you want to add together?:   ");
        NbrOfItems = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Go ahead and input the {0}  numbers you wish to add.", NbrOfItems);
        Console.Write("\n");


        int Fnum = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i<= NbrOfItems-1; i++)
        {
            Console.Write("\n\n Input the numbers : ");
            n = int.Parse(Console.ReadLine());
            sum = sum + n;
          
        }
        Console.Write("The sum is {0} ", Fnum + sum);

    }























} //end
