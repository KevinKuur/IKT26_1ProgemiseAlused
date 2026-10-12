using System.Threading.Channels;

namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värvi nimi!");
            //kasutab switchi
            //sisestab värvi nime
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "Värv puudub"
            string värv = Console.ReadLine();

            switch (värv)
            {
                case "Red":
                    Console.WriteLine("Sisestasid punase värvi");
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "Green":
                    Console.WriteLine("Sisestasid rohelise värvi");
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "Blue":
                    Console.WriteLine("Sisestasid sinise värvi");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "White":
                    Console.WriteLine("Sisestasid valge värvi");
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "Orange":
                    Console.WriteLine("Sisestasid oranži värvi");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.WriteLine("See värv puudub");
                    break;

            }
        }
    }
}
