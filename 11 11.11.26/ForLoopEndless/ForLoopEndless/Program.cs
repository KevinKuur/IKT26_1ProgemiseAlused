namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Endless For Loop!");

            ushort counter = 1;
            for (; ; )
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
                if (counter == 10)
                {
                    break; // Exits the loop when counter reaches 10
                }

            }
        }
    }
}
