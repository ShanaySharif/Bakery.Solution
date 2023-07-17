//UI Logic 

using System;
using Bakery.Models;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Today's Special: Buy 2 loaves get 1 free & Buy 3 pastries get 1 free");
            Console.WriteLine("Bread loaves cost $5 each, And Pastries are $2 a piece!");
            try
            {
                Console.WriteLine("How many loaves of bread would you like to order? Please Enter Amount:");
                int breadOrder = int.Parse(Console.ReadLine());
                Console.WriteLine("How many pastries would you like to order? Please Enter Amount:");
                int pastryOrder = int.Parse(Console.ReadLine());

                Bread newBread = new Bread(breadOrder);
                Pastry newPastry = new Pastry(pastryOrder);

                int breadCost = newBread.BreadCost();
                int pastryCost = newPastry.PastryCost();
                int totalAmount = breadCost + pastryCost;

                Console.WriteLine("Your order:");
                Console.WriteLine($"Bread loaves: {breadOrder}");
                Console.WriteLine($"Pastries: {pastryOrder}");

                Console.WriteLine($"Final Amount: ${totalAmount}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" There was an error.Please try again!! {e.Message}");
                Console.WriteLine("Please enter a postive whole number for your order.");
            }

            Console.WriteLine("Would you like to make another order? Please enter 'yes' or 'no'.");
            if (Console.ReadLine().Trim().ToLower().StartsWith("y"))
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thank you for your order! Hope to see you soon!");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
        }
    }
}