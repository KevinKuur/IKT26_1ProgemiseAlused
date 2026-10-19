namespace Switchbetweennumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switchbetweennumbers!");
            //esimene koondtulemuse puhul on number vahemikus
            //0 kuni 100,
            //teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasutada switchi
            // parsige tähemärk numbriks
            string betweennumbers = Console.ReadLine();

            switch (betweennumbers)
            {
                case "0 - 100":
                    Console.WriteLine("this number is between 0 - 100");
                    break;
                case "101 - 200":
                    Console.WriteLine("this number is between 101 - 200");
                    break;
                case "201 - 300":
                    Console.WriteLine("this number is between 201 - 300");
                    break;
                default:
                    Console.WriteLine("mingi muu number");
                    break;
            }
        }
    }
}
