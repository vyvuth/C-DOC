using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("\n===== Welcome to my baby outlet =====\n");

            // statement code input 
            string? ItemName;
            string? ItemSource;
            string? Cashier;
            int? qty;
            decimal? ItemPrice;


            Console.WriteLine("Item_Name: ");
            ItemName = Console.ReadLine();
            Console.WriteLine("Item_QTY: ");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Item_price: ");
            ItemPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Item_source");
            ItemSource = Console.ReadLine();
            Console.WriteLine("Name_cashier: ");
            Cashier = Console.ReadLine();

            // statement of result 
            Console.WriteLine("\n===== Your payment recipe =====\n");
            Console.WriteLine("Item_Name: " + ItemName);
            Console.WriteLine("Item_QTY: " + qty);
            Console.WriteLine("Item_price: $ " + ItemPrice);
            Console.WriteLine("Item_source: made in " + ItemSource);
            Console.WriteLine("Name_cashier: " + Cashier);

            // Total payment
            Console.WriteLine("Total_Payment: $ " + qty * ItemPrice);

            Console.WriteLine("\n===== Thank You for your ordering🙏🙏 =====\n");
            
            
        }

        static void Main()
        {
            MyMethod();
        }
    }
}