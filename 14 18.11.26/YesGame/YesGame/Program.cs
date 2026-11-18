using System.Threading.Channels;

namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = "";

            //While ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes

            while (word != "yes")
            {
                Console.WriteLine("kirjuta sõna yes või midagi muud");
                word = Console.ReadLine();
            }
            Console.WriteLine("tubli töö");
        }

    }
}
