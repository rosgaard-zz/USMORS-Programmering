namespace GuessMyNumber
{
    public class Program
    {
        //Variabler som styrer hvilket tal computeren tænker på
        private static int minimum = 1;
        private static int maximum = 100;

        /// <summary>
        /// Her begynder programmet. Main()-funktionen kaldes automatisk når programmet starter op.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game();
        }

        /// <summary>
        /// Denne funktion indeholder logikken til spillet
        /// </summary>
        private static void Game()
        {
            Console.WriteLine("\n* * * * * * * GÆT MIT TAL * * * * * * *");
            Console.WriteLine($"Jeg tænker på et tal mellem {minimum} og {maximum}. Kan du gætte hvad tallet er?");

            int NumberToGuess = GenerateRandomNumber(minimum, maximum);
            int userGuess;

            //Do-While løkke som kører rundt indtil brugeren har gættet tallet
            do
            {
                userGuess = UserInputNumber();
                if (userGuess > NumberToGuess)
                {
                    //Brugeren har gættet for højt et tal
                    Console.WriteLine($"Mit tal er mindre end {userGuess}...");
                }
                else if (userGuess < NumberToGuess)
                {
                    //Brugeren har gættet for lavt et tal
                    Console.WriteLine($"Mit tal er større end {userGuess}...");
                }
            }
            while (userGuess != NumberToGuess);

            //Her er vi kommet ud af Do-While løkken, fordi at brugeren har gættet tallet
            Console.WriteLine($"\nTillykke! Du gættede mit tal {NumberToGuess}\n\n");
        }


        /// <summary>
        /// Genererer et tilfældigt heltal mellem minimum og maximum
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        private static int GenerateRandomNumber(int minimum = 1, int maximum = 100)
        {            
            Random random = new Random();
            return random.Next(minimum, maximum + 1);
        }


        /// <summary>
        /// Tager imod brugerens input
        /// </summary>
        /// <returns></returns>
        private static int UserInputNumber()
        {
            Console.WriteLine("\nIndtast dit gæt:");
            string? userInputText = Console.ReadLine();

            //Konverterer brugerens input fra tekst til heltal (int)
            int.TryParse(userInputText, out int number);

            return number;
        }
    }
}
