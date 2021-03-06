using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int sum(bool horiz, char[][] board, int rowcol, bool player1)
        {
            char mark = 'O';
            if (player1) mark = 'X';
            int sum = 0;
            if (horiz)
            {
                for (int i = 0; i < 3; i++) sum += board[rowcol][i] == mark ? 1 : 0;
            }
            else
                for (int i = 0; i < 3; i++) sum += board[i][rowcol] == mark ? 1 : 0; ;
            return sum;
        }
        static bool diagWon(bool up, char[][] board, bool player1)
        {
            char mark = 'O';
            if (player1) mark = 'X';
            if (up)
            {
                if (board[2][0] == mark && board[1][1] == mark && board[0][2] == mark) return true;

            }
            else
            {
                if (board[0][0] == mark && board[1][1] == mark && board[2][2] == mark) return true;
            } return false;
        }
        static bool won(char[][] board, bool player1)
        {
            for (int i = 0; i < 3; i++)
            {
                if (sum(true, board, i, player1) == 3 || sum(false, board, i, player1) == 3) return true;
            }
            return diagWon(true, board, player1) || diagWon(false, board, player1);
        }


        static void Main(string[] args)
        {

            bool isPlayer1 = true;
            char[][] board = new char[][] { new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' } };

            Console.WriteLine("tick tack toe");
            int moves = 0;
            while (true)
            {
                 for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(board[i][0] + "|" + board[i][1] + "|" + board[i][2]);
                }
                string player = "2";
                char mark = 'O';

                if (isPlayer1)
                {
                    player = "1";
                    mark = 'X';
                }
                Console.WriteLine("Player" + player + " go");
                string move = Console.ReadLine();
                int[] intmove = move.Split(' ').Select(x => Convert.ToInt32(x)).ToArray(); ;
                board[intmove[0]][intmove[1]] = mark;
                moves++;
                if (won(board, isPlayer1))
                {
                    Console.WriteLine("Player " + player + " wins!");
                    Console.WriteLine("Press enter to restart");
                    Console.ReadKey();
                    restart(out isPlayer1, board);

                }
                else if (moves == 9)
                {
                    Console.WriteLine("Tie! ");
                    Console.WriteLine("Press enter to restart");
                    Console.ReadKey();
                    restart(out isPlayer1, board);

                }
                else isPlayer1 = !isPlayer1;

            }
        }

        private static void restart(out bool isPlayer1, char[][] board)
        {
            isPlayer1 = true;
            board = new char[][] { new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' } };
        }
    }
}
