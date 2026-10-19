namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "intro to c#" or "Variables" or "Datatypes":
                    Console.WriteLine("Basic");
                    break;

                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                    break;

                default:
                    Console.WriteLine("Unknown course");
                    break;
            }
        }
    }
}
