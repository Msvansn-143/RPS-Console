using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between ROCK,PAPER and SCISSORS:  ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSOR";
                            Console.WriteLine("Computer chose SCISSOR");
                            if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;

                    }
                    Console.WriteLine("\n\nSCORES:\t\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer,scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {
                    Console.WriteLine("DRAW!");
                }
                Console.WriteLine("DO YOU WANT TO PLAY AGAIN?(Y/N)");
                string loop = Console.ReadLine().ToUpper();
                if(loop=="Y")
                {
                    continue;
                   // playAgain = true;
                    //Console.Clear();
                }
                else if(loop=="N")
                {
                    return;
                   // playAgain = false;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
