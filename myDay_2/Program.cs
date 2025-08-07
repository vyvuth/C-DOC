using System;
using System.Linq;

namespace MyApplication;

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

        // Console.WriteLine("==== Welcome to Votting system! ====");
        // Console.WriteLine("Enter Age: ");
        // int Ages = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("\n");
        // Console.WriteLine("==== Your messages ====");

        // if (Ages > 50)
        // {
        //     Console.WriteLine("Over age!!!");
        // }
        // else if (Ages >= 18)
        // {
        //     Console.WriteLine("You're old enough to vote!");
        // }
        // else
        // {
        //     Console.WriteLine("You're under 18. Don't allow for votting!");
        // }
        // Console.WriteLine("\n");


        // Admin access
        // Console.WriteLine("Enter admin username:");
        // string? userName = Console.ReadLine();

        // string passWord = (userName == "@#aDmiN$$dAra") ? "Your login success" : "Invalid password!!";

        // Console.WriteLine(passWord);

        // C# Switch
        // switch to find the day of the week 
        // Console.WriteLine("Enter number of the day:");
        // int ? numberDay = Convert.ToInt32(Console.ReadLine());

        // switch (numberDay)
        // {
        //     case 1:
        //         Console.WriteLine("Today is Monday");
        //         break;
        //     case 2:
        //         Console.WriteLine("Today is Tuesday");
        //         break;
        //     case 3:
        //         Console.WriteLine("Today is Wednesday");
        //         break;
        //     case 4:
        //         Console.WriteLine("Today is Thursday");
        //         break;
        //     case 5:
        //         Console.WriteLine("Today is Friday");
        //         break;
        //     case 6:
        //         Console.WriteLine("Today is Saturday");
        //         break;
        //     case 7:
        //         Console.WriteLine("Today is Sunday");
        //         break;
        //     default:
        //         Console.WriteLine("Looking forward to the calendar!!");
        //         break ;

        // }


        // Caculator using C# 
        /*   
           Console.WriteLine("Enter first num:");
           double? numCal_1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter second num:");
           double? numCal_2 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter: +, -, *, /: ");
           string? op = Console.ReadLine();
           double? result;
           Console.WriteLine("======================================");

           switch (op)
           {
               case "+":
                   result = numCal_1 + numCal_2;
                   break;
               case "-":
                   result = numCal_1 - numCal_2;
                   break;
               case "*":
                   result = numCal_1 * numCal_2;
                   break;
               case "/":
                   if (numCal_2 == 0)
                   {
                       Console.WriteLine("Error: can't divide with zero!!!");
                       return;
                   }
                   result = numCal_1 / numCal_2;
                   break;
               default:
                   Console.WriteLine("Invalid please check your input again!!");
                   return;
           }
           Console.WriteLine($"Result: {result:F2}");*/

        // do while loop 
        // int i = 1;
        // while (i > 0 )
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }
        // do
        // {
        //     Console.WriteLine(i);
        //     i++;
        // } while (i > 0);

        // for loop 
        // for (int i = 0; i <= 2; i++)
        // {
        //     Console.WriteLine("outer: " + i);
        //     for (int j = 0; j <= 13; i++)
        //     {
        //         Console.WriteLine("inner: " + j);
        //     }
        // }
        // string txt = "I Love you so much o mech😘❤️";
        // // Console.WriteLine(txt);

        // for (int i = 1; i <= 1000; i++)
        // {
        //     Console.WriteLine($"{i}. {txt}");
        // }

        // array in C# 
        /*
        string[] cars = new string[10]
         {
            "Toyota",
            "Honda",
            "Ford",
            "Chevrolet",
            "BMW",
            "Mercedes",
            "Hyundai",
            "Nissan",
            "Mazda",
            "Kia"
        };

        Console.WriteLine("┌────┬────────────┐");
        Console.WriteLine("│ No │ Car Name   │");
        Console.WriteLine("├────┼────────────┤");

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"| {i + 1,2} | {cars[i], -10} |");
        }

        Console.WriteLine("└────┴────────────┘");
        */

        // string[] motors = { "honda", "kavasaki", "mslash", };
        // Array.Sort(motors);
        // foreach (string motor in motors)
        // {
        //     Console.WriteLine(motor);
        // }

        // int[] myNum = { 1, 2, 3, };
        // Console.WriteLine(myNum.Max());
        // Console.WriteLine(myNum.Min());
        // Console.WriteLine(myNum.Sum());

        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
}  


    }
}
