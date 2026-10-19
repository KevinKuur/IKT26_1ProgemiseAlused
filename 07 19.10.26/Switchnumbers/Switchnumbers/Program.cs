namespace Switchnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switchnumbers!");
            string numbers = Console.ReadLine();

            //tuleb teha switch, kus esimene case on 10, teine on 20 ja kolmas on 30.
            //küsitakse numbrit ja sisestatud konsooli

            switch (numbers)
            {
                case "10":
                    Console.WriteLine("sisestasid numbri 10");
                    break;
                case "20":
                    Console.WriteLine("sisestasid numbri 20");
                    break;
                case "30":
                    Console.WriteLine("sisestasid numbri 30");
                    break;
                default:
                    Console.WriteLine("mingi muu number");
                    break;

            }
        }
    }
}
