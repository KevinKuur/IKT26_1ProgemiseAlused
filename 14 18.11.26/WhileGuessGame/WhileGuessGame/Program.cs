namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numbri arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;



            while (guess != secretNumber)
            {
                Console.WriteLine("Arva ära number 1 kuni 100-ni");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess <= secretNumber)
                {
                    Console.WriteLine("number on liiga väike");
                }
                else
                {
                    Console.WriteLine("Number on liiga suur");
                }
            }

            Console.WriteLine($"Õige! Arvatud kordade arv: {attempts}");
        }
    }
}
