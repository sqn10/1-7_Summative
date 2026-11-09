using Figgle;
using Figgle.Fonts;

namespace _1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string standardBanner = FiggleFonts.SlantSmall.Render("Rock Paper Scissors");
            Console.WriteLine(standardBanner);
        }
    }
}
