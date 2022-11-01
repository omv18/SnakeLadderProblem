using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class SankeLadder
    {
        int position = 0, count = 0, againLadder = 2;
        const int NOPLAY = 0, LADDER = 1, SNAKE = 2, PlAYERWIN = 100 , CONDITIONCHECK = 93, SNAKENEGATIVE = 0;
        Random random = new Random();

        public int DiceThrow()
        {
            int num = random.Next(1, 7);
            count++;
            return num;
        }
        public int CheckPlay()
        {
            int num = random.Next(0, 3);
            return num;
        }

        public int GamePlay()
        {

            while (position < PlAYERWIN)
            {
                int num = DiceThrow();
                int checkPlay = CheckPlay();
                switch (checkPlay)
                {
                    case NOPLAY:
                        Console.WriteLine("Player is in the same position");
                        break;
                    case LADDER:
                        for (int i = 0; i < againLadder; i++)
                        { 
                            if (position > CONDITIONCHECK)
                            {
                                int hundred = PlAYERWIN - position;
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
                        }
                            break;
                    case SNAKE:
                        //This condition is hardCoded -- Not in the Question.
                        if(position > CONDITIONCHECK)
                        {
                            Console.WriteLine("Snake or Negative part is end");
                            break;
                        }
                        position -= num;
                        Console.WriteLine("Player position is : " + position);
                        if(position < SNAKENEGATIVE) 
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
