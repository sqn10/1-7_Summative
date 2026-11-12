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
            bool done = false;

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

            while (!done)
            {
                if (input.ToUpper() == "Y")
                {
                    Rules();
                    done = true;
                }
                else if (input.ToUpper() == "N")
                {
                    Game();
                    done = true;

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
            bool done = false;

            Console.Clear();

            double userMoney = 100.00;
            double userBet = 0;
            int userChoice;
            int computerChoice;

            Random generator = new Random();
            computerChoice = generator.Next(0, 2);

            Typer("How much to you want to bet?: $");
            Double.TryParse(Console.ReadLine(), out userBet);

            while (!done)
            {
                if (userBet > 100 || userBet < 0.01)
                {
                    Typer("Your bet may not be equal to or less than 0, or greater than 100. Please enter valid input.", 10); Console.WriteLine();
                    Typer("If you are putting in a letter, please,"); Typer(" learn the difference!", 100);
                    Console.WriteLine();
                    Typer("Enter your bet: $");
                    Double.TryParse(Console.ReadLine(), out userBet);

                }
                else
                {
                    done = true;
                }

            }

            Console.WriteLine(); Typer("The computer is choosing its move"); Loader(1000, 3);

            Console.WriteLine();

            Typer("Now choose yours. R for rock, P for paper, S for scissors.")
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
            Typer("You can also choose at any time between turns to display your winnings/losses.");
            Console.WriteLine();
            Typer("Once you quit the game, or start it again, your data will be lost.");
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
        public static void Loader(int lengthInMs, int timesToRpt)
        {
            for (int i = 0; i < timesToRpt; i++)
            {
                Thread.Sleep(lengthInMs);
                Console.Write(".");
            }
        }
    }
}
