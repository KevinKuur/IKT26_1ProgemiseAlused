namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While do!");

            int nr = int.Parse(Console.ReadLine());
            int i = 1;

            //see on siis iteratsioon e tsükkel, mis kordub
            // nii kaua, kui vastab tingimustele
            do
            {
                Console.WriteLine(i);
                //++ suurendab ühe võrra väärstust
                i++;
                Thread.Sleep(1000);

            } while (i <= nr);
        }
    }
}
