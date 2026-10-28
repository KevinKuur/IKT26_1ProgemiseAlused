namespace Ifandelsejärelvastamine2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mis su lemmik toit on");

            string input = Console.ReadLine();

            if (input == "pitsa")
            {
                Console.WriteLine("Sinu lemmik toit on pitsa");
            }
            else if (input == "pasta")
            {
                Console.WriteLine("sinu lemmik toit on pasta");
            }
            else
            {
                Console.WriteLine("Su lemmik toit on midagi muud");
            }


            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta ja");
            string method = Console.ReadLine();

            if (method == "ja")
            {
                Hellomethod();
            }
            else
            {
                Console.WriteLine("Ei soovinud midagi");
            }
        }

        static void Hellomethod()
        {


            Console.WriteLine("Tere tulemast");

            Console.WriteLine("Sisesta esimene number!");
            float firstnr = float.Parse(Console.ReadLine());

          
            Console.WriteLine("Vali tehe *,/,+,-");
            string input = Console.ReadLine();


            Console.WriteLine("Sisesta teine number");
            float secondnr = float.Parse(Console.ReadLine());

            if (secondnr == 0)
            {
                Console.WriteLine("nulliga lahutamine pole lubatud");
            }
            else
            {
                Console.WriteLine($"jagamise tulemuse: {firstnr} - {secondnr} = {firstnr - secondnr}");
                
            }
        }
    }
}
