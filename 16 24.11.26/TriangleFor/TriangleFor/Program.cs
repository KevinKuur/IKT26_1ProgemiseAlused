namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("sisesta ridade arv: ");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            // Välimine tsükkel käib läbi kõik read
            for (i = 1; i <= rows; i++)
            {
                // Sisemine tsükkel prindib igale reale sama palju tärne, kui on rea number
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                // Pärast iga rea tärnide printimist liigume uuele reale
                Console.WriteLine();
            }
        }
    }
}
