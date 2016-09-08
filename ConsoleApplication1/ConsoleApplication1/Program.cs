using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool player1 = true;
            char[][] board = new char[][] {{' ' , ' ', ' '},{' ', ' ' , ' '},{' ', ' ' , ' '} };
           
            Console.WriteLine("tick tack toe");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(board[i][0] + "|" + board[i][1] + "|" + board[i][2]);
            }

            if (player1)
            {
                Console.WriteLine("Player1 go");
                
            }
        }
    }
}
