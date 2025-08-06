using System;

class Program
{
    static void Main()
    {
        // operator arithmetic
        // addition
        // int x = 12;
        // int y = 13;
        // int z = x + y;
        // int z = y - x;
        // int z = x * y;
        // int z = x / y;
        // int z = x % y;
        // x = --x;
        // Console.WriteLine($"decrease: {x}");

        // assignment
        // int x = 20;
        // x += 10;
        // Console.WriteLine(x);

        // Mathematic
        // Math.Max() find the highest value
        // Console.WriteLine($"Max: {Math.Max(5, 10)}");
        // // Math.Min() find the lowest value 
        // Console.WriteLine($"Min: {Math.Min(-0012, 02)}");
        // // The Math.Sqrt(x) method returns the square root of x:
        // Console.WriteLine($"Sqrt: {Math.Sqrt(9)}");
        // // The Math.Abs(x) method returns the absolute (positive) value of x:
        // Console.WriteLine($"Abs: {Math.Abs(-12.76)}");
        // // Math.Round() rounds a number to the nearest whole number:
        // Console.WriteLine($"Round: {Math.Round(99.990)}");

        // string.Conct() concatenation two string 
        // string firstName = "VUTH";
        // string lastName = "VY";
        // string fullName = string.Concat(firstName, " ", lastName);
        // Console.WriteLine(fullName);

        // C# String Interpolation
        // string firstName = "Mork";
        // string lastName = "Sreymech";
        // string name = $"My name is: {firstName} {lastName}";
        // Console.WriteLine(name);

        // C# Access Strings
        // string name = "dara";
        // int chio = name.IndexOf("r");
        // // Console.WriteLine($"Indexof: {chio}");
        // string last = name.Substring(chio); // Substring() extract the character string 
        // Console.WriteLine($"Substring: {last}");

        // Condition statement (make user input age for votting)

        Console.WriteLine("==== Welcome to Votting system! ====");
        Console.WriteLine("Enter Age: ");
        int Ages = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("==== Your messages ====");

        if (Ages > 50)
        {
            Console.WriteLine("Over age!!!");
        }
        else if (Ages >= 18)
        {
            Console.WriteLine("You're old enough to vote!");
        }
        else
        {
            Console.WriteLine("You're under 18. Don't allow for votting!");
        }
        Console.WriteLine("\n");




    }
}
