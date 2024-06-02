using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 game, balanse;
            Single saleGame;
            game = 100;
            saleGame = 0.1f;
            Console.Write("Write your balanse - ");
            balanse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The game costs a {game}. The sale are {saleGame* 100}. End costs to game are {game - game * saleGame}");
            if(balanse >= game - game * saleGame)
            {
                Console.WriteLine($"You buy this game. In Your balanse left {Convert.ToInt32(balanse - (game - game * saleGame))}");
            }
            else {
                Console.WriteLine($"You not buy this game. You need a {Convert.ToInt32((game - game * saleGame) - balanse)} dollars");
            }
            Console.ReadKey();

        }
    }
}
