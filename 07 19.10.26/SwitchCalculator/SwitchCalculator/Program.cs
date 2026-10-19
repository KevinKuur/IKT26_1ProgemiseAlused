namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float firstnr = float.Parse(Console.ReadLine());

            //siin valitakse switch case
            Console.WriteLine("Vali tehe *,/,+,-");
            string input = Console.ReadLine();


            Console.WriteLine("Sisesta teine number");
            float secondnr = float.Parse(Console.ReadLine());


            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati parsimisel

            switch (input)
            {
                case "*":
                    Console.WriteLine($"Liitmise tulemuse: {firstnr} * {secondnr} = {firstnr * secondnr}");
                    break;
                case "-":
                    Console.WriteLine($"Liitmise tulemuse: {firstnr} - {secondnr} = {firstnr - secondnr}");
                    break;
                case "+":
                    Console.WriteLine($"Liitmise tulemuse: {firstnr} + {secondnr} = {firstnr + secondnr}");
                    break;
                case "/":
                   if (secondnr == 0)
                    {
                        Console.WriteLine("nulliga jagamine polw lubatud");
                    }
                   else
                    {
                        Console.WriteLine($"jagamise tulemuse: {firstnr} / {secondnr} = {firstnr / secondnr}");
                    }
                    break;

                default:
                    Console.WriteLine("valisid vale tingimärgi");
                    break;

            }
        }
    }
}
