namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary!");

            Console.WriteLine("Sisesta number: ");

            //tuleb kasutada while

            int number = int.Parse(Console.ReadLine());
            string binary = number == 0 ? "0" : "";

            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }

            Console.WriteLine("Kahendsüsteemis: " + binary);
        
        }
    }
}
