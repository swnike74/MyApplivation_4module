﻿namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;

            do
            {
                Console.WriteLine("Iteration {0}", t);

                var text = Console.ReadLine();

                switch (text)
                {
                    
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;

                        t++;
                }
                if (text == "stop")
                {
                    Console.WriteLine("cycle is stopped");
                    break;
                }
            } while (t < 3);
        }
    }
}
