using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyOne;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[] TotalScore = { 0, 0 };
            while (true)
            {
                Console.WriteLine("Total Score: Player: " + TotalScore[0] + "\tAI: " + TotalScore[1]);
                Console.WriteLine("Press '1' to start new game.\nPress any other key to close program.");
                if (Console.ReadKey().KeyChar != '1')
                    break;
                Console.Clear();
                TwentyOne.TwentyOne Game = new TwentyOne.TwentyOne();
                while (true)
                {
                    Console.Clear();
                    Game.PlayerInfo();
                    Console.WriteLine("Press '1' to take another card.\nPress any other key to pass.");
                    if (Console.ReadKey().KeyChar != '1')
                    {
                        Console.Clear();
                        Game.Finish();
                        Game.FullInfo();

                        switch(Game.CondCheck2())
                        {
                            case 1: 
                            case 3:
                                Console.WriteLine("Player Won!");
                                TotalScore[0]++;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                            case 4:
                                Console.WriteLine("Player Lost!");
                                TotalScore[1]++;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                Console.WriteLine("DRAW!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                break;         
                        }

                        break;
                    }
                    else
                    {
                        Game.TakeCard();
                        if(Game.CondCheck1() == 1)
                        {
                            Console.Clear();
                            Game.PlayerInfo();
                            Console.WriteLine("Player Lost!");
                            TotalScore[1]++;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else if(Game.CondCheck1() == 2)
                        {
                            Console.Clear();
                            Game.PlayerInfo();
                            Console.WriteLine("Player Won!");
                            TotalScore[0]++;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
        }
    }
}
