using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to casino!");
            Console.Write("Show your money - ");
            Int32 money;
            String moneyString = Console.ReadLine();
            while (!Int32.TryParse(moneyString,out money))
            {
                Console.WriteLine("You have mistake. Try agan ");
                Console.Write("Show your money - ");
                moneyString = Console.ReadLine();
            }
            Console.WriteLine("If you want to bet at rulet - write 1");
            switch (Console.ReadLine()) 
            {
                case "1":
                    Console.WriteLine($"You lose {money}. Goodbye");
                    break;
                default:
                    Console.WriteLine("Ok. If you not want to bet - go away");
                    break;

            }
            Console.ReadKey();
        }
    }
}
