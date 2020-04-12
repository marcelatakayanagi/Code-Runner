using System;

namespace Calculadora
{
    public class CodeRunnerEx1
    {
        static string space = " ";
        static int width = 27;

        public static void DrawEmptySpace(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(space);
            }
        }

        public static void DrawButton(string button, ConsoleColor buttonColor)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = buttonColor;
            Console.Write(space);
            Console.Write(button);
            Console.Write(space);
        }

        public static void DrawCalculator(string content, Boolean isOn)
        {
            Console.Clear();

            if (content == null || isOn == false)
                content = "";

            var buttonColor = ConsoleColor.Black;
            if (isOn)
                buttonColor = ConsoleColor.Green;


            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();

            //Draw visor
            DrawEmptySpace(2);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < 23 - content.Length; i++)
            {
                Console.Write(space);
            }
            Console.Write(content);
            DrawEmptySpace(2);
            Console.WriteLine();
            Console.ResetColor();

            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();
            Console.ResetColor();

            //Draw first button line
            DrawEmptySpace(2);
            DrawButton("7", buttonColor);
            DrawEmptySpace(2);
            DrawButton("8", buttonColor);
            DrawEmptySpace(2);
            DrawButton("9", buttonColor);
            DrawEmptySpace(2);
            DrawButton("/", buttonColor);
            DrawEmptySpace(2);
            DrawButton("%", buttonColor);
            DrawEmptySpace(2);
            Console.WriteLine();
            Console.ResetColor();

            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();
            Console.ResetColor();

            //Draw second button line
            DrawEmptySpace(2);
            DrawButton("4", buttonColor);
            DrawEmptySpace(2);
            DrawButton("5", buttonColor);
            DrawEmptySpace(2);
            DrawButton("6", buttonColor);
            DrawEmptySpace(2);
            DrawButton("-", buttonColor);
            DrawEmptySpace(2);
            DrawButton("x", buttonColor);
            DrawEmptySpace(2);
            Console.WriteLine();
            Console.ResetColor();

            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();
            Console.ResetColor();

            //Draw third button line
            DrawEmptySpace(2);
            DrawButton("1", buttonColor);
            DrawEmptySpace(2);
            DrawButton("2", buttonColor);
            DrawEmptySpace(2);
            DrawButton("3", buttonColor);
            DrawEmptySpace(2);
            DrawButton("+", buttonColor);
            DrawEmptySpace(2);
            DrawButton("=", buttonColor);
            DrawEmptySpace(2);
            Console.WriteLine();
            Console.ResetColor();

            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();
            Console.ResetColor();

            //Draw fourth button line
            DrawEmptySpace(2);
            DrawButton("I/O", buttonColor);
            DrawEmptySpace(3);
            DrawButton("0", buttonColor);
            DrawEmptySpace(2);
            DrawButton("C", buttonColor);
            DrawEmptySpace(3);
            DrawButton("CE", buttonColor);
            DrawEmptySpace(2);
            Console.WriteLine();
            Console.ResetColor();

            //Draw empty line
            DrawEmptySpace(width);
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void Calculadora()
        {
            int num1 = 0, num2 = 0;
            Boolean isOn = false, opI = false;
            string visorString = num1.ToString(), op = "";

            while (true)
            {
                DrawCalculator(visorString, isOn);


                Console.WriteLine("Insira o valor de uma das teclas apresentadas ou S para sair");
                var value = Console.ReadLine();
                int tempValue = 0;

                //check if value is number.
                if (int.TryParse(value, out tempValue))
                {
                    if (isOn)
                    {
                        if (opI) //Check if operation has been set. If so, assign value to num2
                        {
                            string num2String = num2.ToString(); //Convert num2 to string
                            num2String = num2String + value; //concatenate num2String and value
                            num2 = int.Parse(num2String); //Assign num1String to num1 (double)
                            visorString = $"{num1}{op}{num2}";
                        }
                        else //If operation has not been set, concatenate value to num1
                        {
                            string num1String = num1.ToString(); //Convert num1 to string
                            num1String = num1String + value; //concatenate num1String and value
                            num1 = int.Parse(num1String); //Assign num1String to num1 (double)
                            visorString = $"{num1}";
                        }
                    }
                }
                else //its not a number
                {
                    if (value == "I/O")
                    {
                        if (isOn)
                        {
                            num1 = 0;
                            num2 = 0;
                            op = "";
                            opI = false;
                            visorString = num1.ToString();
                            isOn = false;
                        }

                        else
                            isOn = true;
                    }
                    else if (value == "+" || value == "-" || value == "x" || value == "/" || value == "%")
                    {
                        if (isOn)
                        {
                            opI = true;
                            op = value;
                            visorString = $"{num1}{op}";
                        }
                    }
                    else if (value == "=")
                    {
                        if (opI && isOn)
                        {
                            switch (op)
                            {
                                case "+":
                                    num1 += num2;
                                    break;
                                case "-":
                                    num1 -= num2;
                                    break;
                                case "x":
                                    num1 *= num2;
                                    break;
                                case "/":
                                    num1 /= num2;
                                    break;
                                case "%":
                                    num1 %= num2;
                                    break;
                            }
                            visorString = $"{num1}";
                            op = "";
                            opI = false;
                            num2 = 0;
                        }
                    }
                    else if (value == "C")
                    {
                        num1 = 0;
                        num2 = 0;
                        op = "";
                        opI = false;
                        visorString = num1.ToString();
                    }
                    else if (value == "CE")
                    {
                        if (!opI)
                        {
                            num1 = 0;
                            visorString = $"{num1}";
                        }
                        else
                        {
                            num2 = 0;
                            visorString = $"{num1}{op}";
                        }
                    }
                    else if (value == "S")
                    {
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                DrawCalculator(visorString, isOn);

            }
        }
    }
}
