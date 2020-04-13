using System;

namespace RockPaperScissors
{
    public class CodeRunnerEx4
    {
        public static void RockPaperSicissors()
        {
            int moves = 0;
            string inputPlayer = null;
            string inputCPU = null;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("A melhor de...");
            moves = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do jogador");
            var player = Console.ReadLine();

            bool playAgain = true;

            while (scorePlayer < moves && scoreCPU < moves)
            {
                Console.WriteLine("Escolha entre pedra, papel, tesoura");
                inputPlayer = Console.ReadLine().ToLower();

                Random rnd = new Random();
                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        Console.WriteLine("O computador escolheu pedra");
                        if(inputPlayer == "pedra")
                        {
                            Console.WriteLine("Empatou!");
                        }else if (inputPlayer == "papel")
                        {
                            Console.WriteLine($"{player} ganhou!");
                            scorePlayer++;
                        }else if (inputPlayer == "tesoura")
                        {
                            Console.WriteLine("Computador venceu!");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("O computador escolheu papel");
                        if (inputPlayer == "papel")
                        {
                            Console.WriteLine("Empatou!");
                        }
                        else if (inputPlayer == "tesoura")
                        {
                            Console.WriteLine($"{player} ganhou!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "pedra")
                        {
                            Console.WriteLine("Computador venceu!");
                            scoreCPU++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("O computador escolheu tesoura");
                        if (inputPlayer == "tesoura")
                        {
                            Console.WriteLine("Empatou!");
                        }
                        else if (inputPlayer == "pedra")
                        {
                            Console.WriteLine($"{player} ganhou!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "papel")
                        {
                            Console.WriteLine("Computador venceu!");
                            scoreCPU++;
                        }
                        break;
                    default:
                        Console.WriteLine("Inválido");
                        break;

                }
                Console.WriteLine($"Pontuação:{player}: {scorePlayer}. | Computador: {scoreCPU}.");

            }

            if (scorePlayer == moves)
            {
                Console.WriteLine($"{player} venceu!!!!");
            }
            else if (scorePlayer == scoreCPU)
            {
                Console.WriteLine("Empate!!!!");
            }
            else
            {
                Console.WriteLine("Computador venceu!!!!");
            }

        }


    }
}

