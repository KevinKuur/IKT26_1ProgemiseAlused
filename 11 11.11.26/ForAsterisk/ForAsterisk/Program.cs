namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asterisk!");

            int nr = int.Parse(Console.ReadLine());
            //vooskeem teha
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
