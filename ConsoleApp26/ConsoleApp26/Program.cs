using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int iteractionFor = 1;
            String password = "123456",passwordInput;
            Console.WriteLine("Authorization in system");

            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Write your password - ");
                passwordInput = Console.ReadLine();
                if (passwordInput == password)
                {
                    Console.WriteLine("Your password right! Conecting system.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Is not your password. Try again. You have {5 - (i + iteractionFor)} trying.");
                }
            }
            Console.ReadKey();
            
        }
    }
}
