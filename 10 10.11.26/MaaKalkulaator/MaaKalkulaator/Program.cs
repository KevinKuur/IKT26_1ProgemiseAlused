namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa Ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust 6371 km

            double coinDiameter = 25.75; //mm
            double earthRadius = 6371000000.0; //mm

            double ümbermõõt = earthRadius * 2.0 * Math.PI;
            double answer = ümbermõõt / coinDiameter;
            Console.WriteLine($"Maa ümbermõõt on {ümbermõõt} mm");
            Console.WriteLine($"Mündi diameeter on {coinDiameter} mm");
            Console.WriteLine($"Järjestikku mahub {answer:N0} münti ümber maa");
        }
    }
}
