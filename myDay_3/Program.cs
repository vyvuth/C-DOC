using System;

namespace MyApplication
{
    class Program
    {
        // without parameter 
        static void MyMethod()
        {
            Console.WriteLine("I love you so much.");
        }

        // with parameter 
        static void MyMethod2(string fname, int carYear)
        {
            // Console.WriteLine("Hello guy, my name is "+ fname + ". And I am 22 years old");
            Console.WriteLine("The cars brand are " + fname + ". Year is " + carYear + ".");
        }
        // name argument 
        static void MyMethod3(string child1, string child2, string child3)
        {
            Console.WriteLine("My name is " + child1);
            Console.WriteLine("My name is " + child2);
            Console.WriteLine("My name is " + child3);
        }
        static void Main(string[] args)
        {
            // Method in C# without parameter
            // MyMethod();
            // MyMethod();

            // Method in c# with parameter 
            // MyMethod2("VUTHVY");
            // MyMethod2("Volvo", 2025);

            // MyMethod in c# with name agument 
            MyMethod3(child1: "Mongkol", child2: "Leakhena", child3: "Vireak");
        }
    }
}