namespace Ifandelsejärelvastamine3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IfandElseRakendus");
            string Elupunkt = Console.ReadLine();
            int Number = int.Parse(Elupunkt);

            if (Number >= 1 && Number <= 29)
            {
                Console.WriteLine("Oled mraskelt haavatud leia kiiresti ravijook");
            }
            else if (Number >= 30 && Number <= 69)
            {
                Console.WriteLine("Oled vigastatud, taasta elupunkte");
            }
            else if (Number >= 70 && Number <= 100)
            {
                Console.WriteLine("Oled võitluseks valmis");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
