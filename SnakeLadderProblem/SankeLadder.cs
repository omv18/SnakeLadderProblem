using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class SankeLadder
    {
        int position = 0, count = 0;
        Random random = new Random();
        //UC3
        public int GamePlay()
        {
            while (position < 100)
            {
                int num = random.Next(1, 7);
                int check = random.Next(0, 3);
                switch (check)
                {
                    case 0:
                        Console.WriteLine("Player is in the same position");
                        count++;
                        break;
                    case 1:
                        count++;
                        if (position > 93)
                        {
                            int hundred = 100 - position;
                            Console.WriteLine("Game is in the LAST PHASE and position is :" + position);
                            if (hundred >= num)
                            {
                                position += num;
                                Console.WriteLine("Player position is : " + position);
                            }
                            else
                            {
                                Console.WriteLine("Wait For the Next Round Until you get the exact 100");
                            }
                        }
                        else
                        {
                            position += num;
                            Console.WriteLine("Player position is : " + position);
                        }

                        break;
                    case 2:
                        count++;
                        if(position > 93)
                        {
                            Console.WriteLine("Snake or Negative part is end");
                            break;
                        }
                        position -= num;
                        Console.WriteLine("Player position is : " + position);
                        if(position < 0) 
                        { 
                            position = 0;
                            Console.WriteLine("Player position change to 0 . So the player again Restart From O");
                        }
                        break;
                }
            }
            Console.WriteLine("total number of DICE roll to win a game is "+ count);
            return count;
        }
    }
}
