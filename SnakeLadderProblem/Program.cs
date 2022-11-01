using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            SankeLadder sn = new SankeLadder();
            int player1 = sn.GamePlay();
            SankeLadder sn1 = new SankeLadder();
            int player2 = sn1.GamePlay();
            Console.WriteLine("Player 1  total number dice roll is  " +player1);
            Console.WriteLine("Player 2  total number dice roll is  " + player2);
            int check = player1.CompareTo(player2);    
            if(check == 0)
            {
                Console.WriteLine("Game is Tie");
            }
            if(check == 1)
            {
                Console.WriteLine("Player 2 Wins the match");
            }
            else
            {
                Console.WriteLine("Player 1 Wins the match");
            }
        }
    }
}
