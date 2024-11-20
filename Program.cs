using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a shipping method code
            Console.WriteLine("Enter the shipping method code (1 for Standard, 2 for Express, 3 for Overnight):");
            int shippingMethod = Convert.ToInt32(Console.ReadLine());

            // Use a switch statement to determine the delivery time based on the code
            switch (shippingMethod)
            {
                case 1:
                    Console.WriteLine("Standard Shipping: 5-7 business days.");
                    break;
                case 2:
                    Console.WriteLine("Express Shipping: 2-3 business days.");
                    break;
                case 3:
                    Console.WriteLine("Overnight Shipping: 1 business day.");
                    break;
                default:
                    Console.WriteLine("Invalid shipping method code. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
}
