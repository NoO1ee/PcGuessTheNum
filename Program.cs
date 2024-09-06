namespace Pc_Guess_the_Num;

internal class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        Console.WriteLine("Welcome to Pc Guess The Num.");
        Console.WriteLine("Press any key to start!");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Type a number that the PC should guess");

        int guess = int.Parse(Console.ReadLine());

        int min = 1;
        int max = 100;

        bool start = true;

        while (start)
        {
            int random = rand.Next(min, max + 1);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your guess is: {guess}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The Computer guesses: {random}\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Use UpArrow(Higher) or LowArrow(Lower) or Enter(Right)");
            Console.WriteLine("Is the awnser Higher or Lower or is the awnser right?");

            var keyPressed = Console.ReadKey().Key;

            if (keyPressed == ConsoleKey.Enter && random == guess)
            {
                Console.Clear() ;
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("The guess was corret and the computer wins!");
                Console.WriteLine($"The awnser was {guess} and the bot guessed {random}");

                Console.ReadKey();
                start = false;
            }
            else if (keyPressed == ConsoleKey.UpArrow && random < guess)
            {
                Console.Clear();
                min = random + 1;
                Console.WriteLine("The number is higher! The computer will guess again.");

            }
            else if (keyPressed == ConsoleKey.DownArrow && random > guess)
            {
                Console.Clear();
                max = random - 1;
                Console.WriteLine("The number is lower! The computer will guess again.");


            }
            else
            {
                Console.WriteLine("The bot did not guess anything.");
                start = false;  
            }

        }
        
    }
}
