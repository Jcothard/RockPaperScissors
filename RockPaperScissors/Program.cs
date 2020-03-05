using System;



namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPlayer;
            int randomInt;
           
            bool playAgain = true;

                while (playAgain)
            { 
                int scorePlayer = 0;
                int scoreCPU = 0;



                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between Rock, Paper, Scissors    ");
                    inputPlayer = Console.ReadLine();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            Console.WriteLine("Computer Chooses Rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player Wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player Loses");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Computer Chooses Paper");
                            if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player Wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Player Loses");
                                scoreCPU++;
                            }

                            break;

                        case 3:
                            Console.WriteLine("Computer Chooses Scissors");
                            if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Player Wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player Loses");
                                scoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU Won");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play Again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            } }  
    }
}
