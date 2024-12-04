namespace Dice
{
    internal class Program
    {
        private static int minimum = 1;
        private static int maximum = 6;
        private static Random random;
        private static int throws = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("\n* * * * * * TERNING * * * * * *\n");
            Console.WriteLine("Tryk på en tast for at slå en terning. Tryk på Q for at afslutte.\n");

            random = new Random();

            //Så længe at tasten der trykkes på ikke er Q
            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                RollDice();
            }
        }


        /// <summary>
        /// Kast en terning
        /// </summary>
        private static void RollDice()
        {
            Console.Clear();
            Console.WriteLine("\n* * * * * * TERNING * * * * * *\n");
            Console.WriteLine("Tryk på en tast for at slå en terning. Tryk på Q for at afslutte.\n");

            //Lav et tilfældigt heltal mellem minimum og maximum
            int die = random.Next(minimum, maximum + 1);

            //Læg én til antal kast
            throws++;
            
            //Udskriv kast nummer og det tilfældige tal
            Console.WriteLine($"\nKast nummer {throws}. Du slog: {die}\n");
        }
    }
}
