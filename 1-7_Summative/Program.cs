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
            Console.WriteLine("To start. Would you like rules? Type Y for rules, or N to start.");


            input = Console.ReadLine();

            while (true)
            {
                if (input.ToUpper() == "Y")
                {
                    Rules();
                    break;
                }
                else if (input.ToUpper() == "N")
                {
                    Game();
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                    input = Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        public static void Game()
        {
            Console.Clear();

            double userMoney = 100.00;
            double userBet = 0;
            int userChoice;
            int computerChoice;

            Random generator = new Random();
            computerChoice = generator.Next(0, 2);

            Typer("How much to you want to bet?"); Console.WriteLine();
            Double.TryParse(Console.ReadLine(), out userBet);

            Console.WriteLine(); Typer("The computer is choosing"); Loader(200);
        }
        public static void Rules()
        {
            Console.Clear();

            string standardBanner = FiggleFonts.SlantSmall.Render("RULES");
            Typer(standardBanner, 5);

            Console.WriteLine();

            Typer("This is a simple game of rock, paper, scissors, with betting involved.");
            Console.WriteLine();
            Typer("You will first type an amount of money to bet, within $100.");
            Console.WriteLine();
            Typer("Then, the computer will make its choice. When it is done, make yours!");
            Console.WriteLine();
            Typer("You will then see if you won, both your move and the money.");
            Console.WriteLine();
            Typer("When you have no money left, the computer will ask if you want to restart, or quit and display your winnings/losses.");

            Console.WriteLine();
            Console.WriteLine();

            Typer("You have finished reading the rules now. Press ENTER to start the game.");
            Console.ReadLine();
            Game();
        }
        public static void Typer(string text, int length = 20)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(length);
            }
        }
        public static void Loader(int length)
        {
            Console.Write(".");
            Thread.Sleep(length);
            Console.Write(".");
            Thread.Sleep(length);
            Console.Write(".");
        }
    }
}
