namespace Swiitch1rühmkuurajärv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();
            string method = Console.ReadLine();
            string name = Console.ReadLine();

            Console.WriteLine("sisesta esimene number!");
            float firstnr = float.Parse(Console.ReadLine());


            Console.WriteLine("sisesta teine number");
            float secondnr = float.Parse(Console.ReadLine());

            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta ja");

            switch(method == "ja")
            {
                case "method":
                    Console.WriteLine("Meetodi nimi on auh");
                    static void hellomethod();
                    Console.WriteLine("Auh");
                        
                    break;

            }
            switch(name == "Kevin")
            {
                case "Name":
                    Console.WriteLine("Sinu nimi on Kevin");
                    break;

                default:
                    Console.WriteLine("sinu nimi ei ole Kevin");
                    break;
            }

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Liitmise tulemuse: {firstnr} + {secondnr} = {firstnr + secondnr}");
                    break;

                
            }
        }
    }
}
