using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fruit: ");
            string fruit = Console.ReadLine().ToLower();
            Console.WriteLine("How many Kilograms would you like to purchase? ");
            double kgs = double.Parse(Console.ReadLine());
            double Price;
            switch (fruit)
            {
                case "apple":
                    Price = 1.25 * kgs;
                    Console.WriteLine("Price for {0}kgs of Apples is ${1}",kgs,Price);
                    break;
                case "bannana":
                    Price = 3.15 * kgs;
                    Console.WriteLine("Price for {0}kgs of Apples is ${1}", kgs,Price);
                    break;
                case "kiwifuit":
                    Price = 4.65 * kgs;
                    Console.WriteLine("Price for {0}kgs of Apples is ${1}", kgs,Price);
                    break;
                case "oranges":
                    Price = 2.75 * kgs;
                    Console.WriteLine("Price for {0}kgs of Apples is ${1}", kgs,Price);
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;

            }

        }
    }
}
