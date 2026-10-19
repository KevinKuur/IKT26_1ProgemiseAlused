namespace IfElseMajaSuurus
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Sisesta maja suurus: ");
            int size = int.Parse(Console.ReadLine());

            //esimene tingimus on alati if, teised on else if ja viimane on else
            if (size >= 0 && size <= 40)
            {
                Console.WriteLine($"sinu maja suurus on {size} m2.");
            }
            else if (size >= 41 && size <= 90)
            {
                Console.WriteLine($"sinu maja suurus on {size} m2.");
            }
            else if (size >= 91 && size <= 130)
            {
                Console.WriteLine($"sinu maja suurus on {size} m2.");
            }
            else if (size >= 131)
            {
                Console.WriteLine($"sinu maja suurus on {size} m2.");
            }
            else
            {
                Console.WriteLine($"Sisestatud väärtus ei ole kehtiv");
            }
        }
    }
}