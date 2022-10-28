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
            while (position < 100)
            {
                int num = random.Next(1, 7);
                int check = random.Next(0, 3);
                switch (check)
                {
                    case 0:
                        Console.WriteLine("Player is in the same position");
                        break;
                    case 1:

                        if (position > 93)
                        {
                            int hundred = 100 - position;
                            Console.WriteLine("Game is ib the LAST PHASE and position is :" + position);
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
                        if(position > 93)
                        {
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
            
        }
    }
}
