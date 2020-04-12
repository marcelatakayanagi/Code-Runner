using System;

namespace JogoDaForca
{
    public class CodeRunnerEx3
    {
        public static void JogoDaForca()
        {
            Boolean a = false, b = false, c = false, d = false, e = false, f = false, g = false, h = false, i = false, j = false, k = false, l = false, m = false, n = false, o = false, p = false, q = false, r = false, s = false, t = false, u = false, v = false, w = false, x = false, y = false, z = false;


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
            string tentativas = "";
            int mistakes = 6;

            //draw forca
            Console.WriteLine("________");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("________");
            Console.WriteLine("Letras Tentadas: " + tentativas);

            for (int index = 0; index < secretWord.Length; index++)
            {
                Console.Write("_ ");
            }

            Console.WriteLine("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;




        }
    }
}
