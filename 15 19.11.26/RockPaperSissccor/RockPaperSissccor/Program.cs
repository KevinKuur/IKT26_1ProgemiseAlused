namespace RockPaperSissccor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kivi paber käärid");

            Random rand = new Random();

            string plrChoice = "";
            string compChoice = "";
            int compNum = 0;
            int plrPoints = 0;
            int compPoints = 0;

            while (plrChoice != "lõpeta")
            {
                Console.WriteLine("vali kivi, paper või käärid");
                Console.WriteLine("või lõpeta et lõpetada");

                plrChoice = Console.ReadLine().ToLower();

                if (plrChoice == "lõpeta")
                {
                    break;
                }
                else if (plrChoice != "kivi" && 
                    plrChoice != "paber" &&
                    plrChoice != "käärid")
                {
                    Console.WriteLine("valikut pole, proovi uuesti!");
                }

                compNum = rand.Next(1, 4);

                if (compNum == 1)
                {
                    compChoice = "kivi";
                }
                else if (compNum == 2)
                {
                    compChoice = "paber";
                }
                else if (compNum == 3)
                {
                    compChoice = "käärid";
                }

                Console.WriteLine("arvuti valis " + compChoice);

                // judging
                
                if (plrChoice == "kivi" && compChoice == "käärid")
                {
                    Console.WriteLine("sa võitsid");
                    plrPoints++;
                }
                else if (plrChoice == "kivi" && compChoice == "paber")
                {
                    Console.WriteLine("sa kaotasid");
                    compPoints++;
                }
                else if (plrChoice == "paber" && compChoice == "kivi")
                {
                    Console.WriteLine("sa võitsid");
                    plrPoints++;
                }
                else if (plrChoice == "paber" && compChoice == "käärid")
                {
                    Console.WriteLine("sa kaotasid");
                    compPoints++;
                }
                else if (plrChoice == "käärid" && compChoice == "paber")
                {
                    Console.WriteLine("sa võitsid");
                    plrPoints++;
                }
                else if (plrChoice == "käärid" && compChoice == "kivi")
                {
                    Console.WriteLine("sa kaotasid");
                    compPoints++;
                }
                else if (plrChoice == compChoice)
                {
                    Console.WriteLine("viik");
                }
                else
                {
                    Console.WriteLine("idk mees");
                }
                Console.WriteLine("su punkti: " + plrPoints);
                Console.WriteLine("arvuti punkti: " + compPoints);
            }
        }
    }
}
