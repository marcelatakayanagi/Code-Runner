using System;

namespace JogoDoGalo
{
    public class CodeRunnerEx2
    {
        public static void JogoDoGalo()
        {
            string A1 = "_", A2 = "_", A3 = "_", B1 = "_", B2 = "_", B3 = "_", C1 = "_", C2 = "_", C3 = "_";
            Boolean continuar = true;
            string player1key = "", player2key = "";

            while (continuar)
            {
                A1 = "_"; A2 = "_"; A3 = "_"; B1 = "_"; B2 = "_"; B3 = "_"; C1 = "_"; C2 = "_"; C3 = "_";
                DrawTable();

                Console.WriteLine("Caractere do jogador 1");
                player1key = Console.ReadLine();
                Console.WriteLine("\nCaractere do jogador 2");
                player2key = Console.ReadLine();
                Console.WriteLine();

                Boolean hasEnded = false;


                while (!hasEnded)
                {
                    askPlayer(1);
                    DrawTable();
                    if (checkWinner())
                        break;
                    askPlayer(2);
                    DrawTable();
                    hasEnded = checkWinner();
                }

                Console.WriteLine("Jogar de novo? S/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                    continuar = false;

            }


            Boolean checkWinner()
            {
                string winner = "";
                if (A1 != "_" && ((A1 == A2 && A2 == A3) || (A1 == B2 && B2 == C3) || (A1 == B1 && B1 == C1)))
                    winner = A1;
                else if (B2 != "_" && ((B1 == B2 && B2 == B3) || (A2 == B2 && B2 == C2) || (C1 == B2 && B2 == A3)))
                    winner = B2;
                else if (C3 != "_" && ((C1 == C2 && C2 == C3) || (A3 == B3 && B3 == C3)))
                    winner = C3;



                if (winner != "")
                {
                    Console.WriteLine($"O vencedor é {winner}");
                    return true;
                }
                else
                {
                    if (A1 != "_" && A2 != "_" && A3 != "_" && B1 != "_" && B2 != "_" && B3 != "_" && C1 != "_" && C2 != "_" && C3 != "_")
                    {
                        Console.WriteLine("Deu Galo!");
                        return true;
                    }
                }

                return false;
            }

            void askPlayer(int player)
            {
                string playerKey = "";
                if (player == 1)
                    playerKey = player1key;
                else
                    playerKey = player2key;


                Console.WriteLine($"Introduza a coluna e linha que o jogador {player} deseja jogar [CL]");
                string cl = Console.ReadLine();
                switch (cl)
                {
                    case "A1":
                        if (A1 == "_")
                            A1 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "A2":
                        if (A2 == "_")
                            A2 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "A3":
                        if (A3 == "_")
                            A3 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "B1":
                        if (B1 == "_")
                            B1 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "B2":
                        if (B2 == "_")
                            B2 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "B3":
                        if (B3 == "_")
                            B3 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "C1":
                        if (C1 == "_")
                            C1 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "C2":
                        if (C2 == "_")
                            C2 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                    case "C3":
                        if (C3 == "_")
                            C3 = playerKey.ToString();
                        else
                            Console.WriteLine("Essa posição já está preenchida");
                        break;
                }
            }

            void DrawTable()
            {
                Console.Clear();
                Console.WriteLine("     A   B   C    ");
                Console.WriteLine($" 1  _{A1}_|_{B1}_|_{C1}_   ");
                Console.WriteLine($" 2  _{A2}_|_{B2}_|_{C2}_   ");
                Console.WriteLine($" 3  _{A3}_|_{B3}_|_{C3}_   ");
            }

        }
       
    }
}
