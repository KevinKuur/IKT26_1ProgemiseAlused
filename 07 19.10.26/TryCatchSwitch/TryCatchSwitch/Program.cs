namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch switch!");
            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;

                }
            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");
            }
            //antud juhul on lubatud maksimaalselt 32-bit-ine number
            catch
            {
                Console.WriteLine("Number on liiga suur");
            }
        }
    }
}
