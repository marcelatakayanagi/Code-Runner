using System;

namespace JogoDaForca
{
    public class CodeRunnerEx3
    {
        public static void JogoDaForca()
        {
            static void DrawForca(int erros)
            {
                Console.Clear();
                Console.WriteLine($"Você ainda tem {erros} tentativas");
                Console.WriteLine("________");
                Console.WriteLine("|      |");
                Console.WriteLine("|      |");
                if
                    (erros >= 6) Console.WriteLine("|       ");
                else
                    Console.WriteLine("|      O ");
                if (erros > 5 && erros < 6)
                    Console.WriteLine("|      | ");
                else if (erros > 4 && erros < 5)
                    Console.WriteLine("|     /| ");
                else if (erros > 3 && erros < 4)
                    Console.WriteLine("|     /|\\");
                else
                    Console.WriteLine("|        ");
                if (erros > 2 && erros < 3)
                    Console.WriteLine("|      | ");
                else
                    Console.WriteLine("|       ");
                if (erros > 1 && erros < 1)
                    Console.WriteLine("|     / ");
                else
                    Console.WriteLine("|       ");
                if (erros > 0 && erros < 1)
                    Console.WriteLine("|      /\\");
                else
                    Console.WriteLine("|       ");
                Console.WriteLine("________");
            }


            static string RandomWord()
            {
                int randomNumber = new Random().Next(1, 10);
                switch (randomNumber)
                {
                    case 1:
                        return "carro";
                    case 2:
                        return "macarrão";
                    case 3:
                        return "pivetada";
                    case 4:
                        return "beliche";
                    case 5:
                        return "cachorro";
                    case 6:
                        return "cerveja";
                    case 7:
                        return "otorrinolaringologista";
                    case 8:
                        return "piranha";
                    case 9:
                        return "guaxinim";
                    case 10:
                        return "lantejola";
                    default:
                        return "qualquer";
                }
            }

            string secretWord = RandomWord();
            string result = "";
            int mistakes = 6;
            Boolean ended = false;

            for (int index = 0; index < secretWord.Length; index++)
            {
                result += "_";
            }

            while (!ended)
            {
                
                //draw forca
                DrawForca(mistakes);
                for (int index = 0; index < secretWord.Length; index++)
                {
                    Console.Write(result[index] + " ");
                }

                Console.WriteLine("Digite uma letra: ");
                char letra = Console.ReadKey().KeyChar;
                Console.WriteLine();

                string newResult = "";
                Boolean acertou = false;
                for (int index = 0; index < secretWord.Length; index++)
                {

                    if (result[index] == '_')
                    {
                        if (letra == secretWord[index])
                        {
                            newResult += letra;
                            acertou = true;
                        }
                        else
                        {
                            newResult += '_';
                        }
                            
                    }
                    else
                    {
                        newResult += result[index];
                    }
                }
                if (!acertou) mistakes--;
                acertou = false;
                result = newResult;

                if(mistakes == 0)
                {
                    Console.WriteLine("Você perdeu. A palavra era: " + secretWord);
                    ended = true;
                }

                if (!result.Contains('_'))
                {
                    Console.WriteLine("Você ganhou! A palavra era:" + secretWord);
                    ended = true;
                }
            }

        }
    }
}
