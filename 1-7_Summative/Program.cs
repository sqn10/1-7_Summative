using Figgle;
using Figgle.Fonts;
using System.Formats.Asn1;
using static System.Net.Mime.MediaTypeNames;

namespace _1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Game();
        }
        public static void Intro()
        {
            string standardBanner = FiggleFonts.SlantSmall.Render("Rock Paper Scissors");
            Typer(standardBanner, 5);

            Console.WriteLine("You have");
            Console.WriteLine();

            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||====================================================================||\r\n||//$\\\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\//$\\\\||\r\n||(100)==================| FEDERAL RESERVE NOTE |================(100)||\r\n||\\\\$//        ~         '------========--------'                \\\\$//||\r\n||<< /        /$\\              // ____ \\\\                         \\ >>||\r\n||>>|  12    //L\\\\            // ///..) \\\\         L38036133B   12 |<<||\r\n||<<|        \\\\ //           || <||  >\\  ||                        |>>||\r\n||>>|         \\$/            ||  $$ --/  ||        One Hundred     |<<||\r\n||<<|      L38036133B        *\\\\  |\\_/  //* series                 |>>||\r\n||>>|  12                     *\\\\/___\\_//*   1989                  |<<||\r\n||<<\\      Treasurer     ______/Franklin\\________     Secretary 12 />>||\r\n||//$\\                 ~|UNITED STATES OF AMERICA|~               /$\\\\||\r\n||(100)===================  ONE HUNDRED DOLLARS =================(100)||\r\n||\\\\$//\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\\\$//||\r\n||====================================================================||\r\n");
            Console.ResetColor();
            
            Thread.Sleep(500);

            string input;
            Console.WriteLine("Would you like rules? Type Y for rules, or N to start.");


            input = Console.ReadLine();

            while (true)
            {
                if (input.ToUpper() == "Y")
                {
                    Rules();
                    Console.Clear();
                    break;
                }
                else if (input.ToUpper() == "N")
                {
                    Game();
                    Console.Clear();
                    break;
                }
                else
                    Console.WriteLine("Invalid input. Try again.");
                    input = Console.ReadLine();    
            }

        }
        public static void Game()
        {
            double userMoney = 100.00;
            double userBet = 0;
            int userChoice;
            int computerChoice;

            Random generator = new Random();
            computerChoice = generator.Next(0, 2);

            Typer("");
        }
        public static void Rules()
        {
            Console.WriteLine("Rules here.");
        }
        public static void Typer(string text, int length = 20)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(length);
            }
        }
    }
}
