namespace ForLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("--------------------------------------");
            Console.Write("\n\n");
            // Eelnevaid teadmisi
            //Kasutada for loopi ja kasutaja saab sisestada korduse arvu
            int arv = Int16.Parse(Console.ReadLine());
            //Console.Clear();

            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("See rida on nr {0}", i);
                string a = "kill-koll";
                string b = "killadi-koll";

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(a);
                }

                for (int k = 1; k <= 1; k++)
                {
                    Console.WriteLine(b);
               }
            }
         }
      }
   }
