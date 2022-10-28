using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class SankeLadder
    {
        int position = 0;
        Random random = new Random();
        //UC3
        public void GamePlay()
        {
            int num = random.Next(1,7);
            int check = random.Next(0,3);
            switch (check)
            {
                case 0:
                    Console.WriteLine("Player is in the same position");
                    break;
                case 1:
                    position += num;
                    Console.WriteLine("Player position is : " + position);
                    break;
                case 2:
                    position -= num;
                    Console.WriteLine("Player position is : " + position);
                    break;
            }
            
        }
    }
}
