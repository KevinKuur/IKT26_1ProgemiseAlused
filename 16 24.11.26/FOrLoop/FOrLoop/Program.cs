using System.Data;

namespace FOrLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kõrgus (vähemalt 3): ");

            if (!int.TryParse(Console.ReadLine(), out int height) || height < 3)
            {
                Console.WriteLine("sisesta täisarv: ");
                return;
            }

            for (int row = 1; row <= height; row++)
            {
                for (int empty = 1; empty <= height - row; empty++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= 2 * row - 1; star++)
                {
                    bool thing =
                        (row == 2 && star == 1) ||
                        (row == height - 1 && star == 2 * row - 1) ||
                        (row == height && star == row);
                    Console.Write(thing ? "o" : "*");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= 2; row++)
            {
                for (int empty = 1; empty < height; empty++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            Console.ResetColor();
        }
    }
}
