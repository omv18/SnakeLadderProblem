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
        //UC2
        public void GamePlay()
        {
            int num = random.Next(1,7);
            Console.WriteLine("Dice number is: "+num);
        }
    }
}
