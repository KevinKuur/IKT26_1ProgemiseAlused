namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");

            // genereerib juhuslikke numbreid 1 kuni 6
            int randomNumber = new Random().Next(1, 7);

            //kasutada switchi
            //peab kontrollima tulemust ja kuvama vastavad sõnumit

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Said 1");
                    break;
                case 2:
                    Console.WriteLine("Said 2");
                    break;
                case 3:
                    Console.WriteLine("Said 3");
                    break;
                case 4:
                    Console.WriteLine("Said 4");
                    break;
                case 5:
                    Console.WriteLine("Said 5");
                    break;
                case 6:
                    Console.WriteLine("Said 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
