using System;

namespace HelloWorld
{
    class Program
{
        static void Main(string[] args)
        {
            // sytax
            // Console.WriteLine("Hello World");

            // Variable
            //  Declearing with string int and char
            /*
            string name = "Daravotey";
            int age = 18;
            char sex = 'F';
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(sex);*/

            // Staff information
            /*
            string name = "VY";
            int age = 22;
            char sex = 'M';
            double salary = 678.90;
            string career = "Web developer";
            string companyLocation = "TK, phnom penh";

            Console.WriteLine($"Name: {name} \n Age: {age}\n Sex: {sex}\n Salary: {salary}\n Career: {career}\n  Company location: {companyLocation}");
            */
            // const 
            // const int Num = 15; // unchange value
            // Num = 30;
            // Console.WriteLine(Num);

            // Display Variable

            // Numberic 
            /*
            int x = 13;
            int y = 43;
            int z = (y - x) * x / y;
            Console.WriteLine($"Total: {z}");
            */

            // stiring 
            // string firstName = "VUTH";
            // string lastName = "VY";
            // string fullName = firstName + " " + lastName;
            // Console.WriteLine(fullName);

            // implicit casting : convert from small to large
            // int x = 9;
            // double myDouble = x;
            // Console.WriteLine($"X: {x}");
            // Console.WriteLine( $"Double: {myDouble}");

            //    explicit casting 
            // double x = 9.78;
            // double y = (int)x;
            // Console.WriteLine($"X: {x}");
            // Console.WriteLine($"Y: {y}");

            // type of conversion method 
            // int x = 16;
            // double y = 45.99;
            // bool z = true;

            // Console.WriteLine($"String: {Convert.ToString(x)}");
            // Console.WriteLine($"Int: {Convert.ToInt32(y)}");
            // Console.Write($"Long: {Convert.ToInt64(y)}\n");
            // Console.Write($"bool to str: {Convert.ToString(z)}\n");
            // Console.Write($"Double: {Convert.ToDouble(x)}\n");
            // Console.Write($"BOOL: {Convert.ToBoolean(y)}");

            // user input 

            // Get user input by Console.ReadLine() in C# 
            // Console.WriteLine("Enter username: ");
            // string userName = Console.ReadLine();
            // Console.WriteLine($"UserName: " + "" + userName);


            // staff input information 
            /*
                        Console.WriteLine("Enter ID: ");
                        string myId = Console.ReadLine();
                        Console.WriteLine("Enter Name:");
                        string myNane = Console.ReadLine();
                        Console.WriteLine("Enter Sex: ");
                        string mySex = Console.ReadLine();
                        Console.WriteLine("Enter Age: ");
                        int myAges = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Job: ");
                        string myJob = Console.ReadLine();
                        Console.WriteLine("Enter Salary: ");
                        double mySalary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\n");
                        Console.WriteLine($" ID: {myId}\n Name: {myNane}\n Sex: {mySex}\n Age: {myAges} year old\n Job: {myJob}\n Salary {mySalary} $");
                        Console.WriteLine("\n");
                */
            // student register
            Console.WriteLine("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Sex: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Enter grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter school fee: ");
            double school_fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"School Fee: {school_fee} $");
            Console.WriteLine("\n");
    }
}
}