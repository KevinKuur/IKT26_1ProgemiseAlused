namespace ForDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, triip!");

            Random random = new Random();

            int playerScore = 0;
            int coumputerScore = 0;
            for (int round = 1; round <= 5; round++)
            {
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);

                Console.WriteLine($"Sinu number: {playerRoll}");
                Console.WriteLine($"Arvuti number: {computerRoll}");

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("sa võitsid vooru!");
                    playerScore++;
                }
                else if (playerRoll < computerRoll)
                {
                    Console.WriteLine("Sa kaotasid vooru");
                    coumputerScore++;
                }
                else
                {
                    Console.WriteLine("Voor jäi viiki");
                }
            }

            if (playerScore > coumputerScore)
            {
                Console.WriteLine();
                Console.WriteLine("Sa võitsid kogu mängu!");
            }
            else if (playerScore < coumputerScore)
            {
                Console.WriteLine();
                Console.WriteLine("Arvuti võitis terve mängu!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Viik");
            }
        }
    }
}
