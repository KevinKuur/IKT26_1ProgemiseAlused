namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = Convert.ToInt32(Console.ReadLine());
            bool isprime = number > 1;

            for (int i = 0; i < number; i++)
            {

            }
            if (isprime)
            {
                Console.WriteLine($"{number} on algarv");
            }
            else
            {
                Console.WriteLine($"{number} ei ole algarv");
            }
        }
    }
}
