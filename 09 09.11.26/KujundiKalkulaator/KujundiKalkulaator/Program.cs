using System.Threading.Channels;

namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ringi pindala ja ümbermõõt

            int roundRadius = 3;
            int diameter = roundRadius * 2;
            

            int pindala = diameter * diameter;
            int ümbermööt = 4 * diameter;

           
            // arvuta siis ringi pindala ja ümbermööt

            double roundarea = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi pindala on:" + roundarea);
            Console.WriteLine("Ringi ümbermööt on:" + roundPerimeter);


            // arvuta siis Ruudud pindala ja ümbermööt

            int squareRadius = 3;
            int Diameter = squareRadius * 2;
            //ruudu pindala on a*a
            double squarearea1 = Math.Pow(Diameter, 2);
            double squarearea2 = Diameter + Diameter;
            double squareperimeter = Diameter * 4;

            Console.WriteLine("Ruudu pindala on:" + squarearea1);
            Console.WriteLine("Ruudu ümbermööt on:" + squarearea2);

            //kuidas teha, et maksimaalselt kaks kohta pärast koma oleks? 

            // Kui tulemus on 28.2743..., kuvatakse 28.27
            // Kui tulemus on täpselt 36, kuvatakse 36 (mitte 36.00)
            Console.WriteLine($"Ringi pindala on: {roundarea:0.##}");
            Console.WriteLine($"Ringi ümbermõõt on: {roundPerimeter:0.##}");

            // Kui tulemus on täpselt 36, kuvatakse 36.00
            Console.WriteLine($"Ringi pindala on: {roundarea:F2}");
            Console.WriteLine($"Ringi ümbermõõt on: {roundPerimeter:F2}");

        }
    }
}
