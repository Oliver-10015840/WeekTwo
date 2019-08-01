using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter a bird type: ");
                string birdType = Console.ReadLine().ToLower();
                switch (birdType)
                {
                    case "pigeon":
                        Console.WriteLine("Correct!");
                        loop = false;
                        break;
                    case "kiwi":
                    case "seagull":
                    case "parrot":
                    case "chicken":
                        Console.WriteLine("Incorrect!");
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
                Console.WriteLine("Try Again!");
                Console.WriteLine();
            }
            Console.WriteLine("Game Over!");
            }
        }
    }
