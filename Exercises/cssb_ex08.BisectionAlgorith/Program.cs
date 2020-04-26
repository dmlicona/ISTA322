using System;
using System.Linq;

namespace cssb_ex08.BisectionAlgorith
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] list = Enumerable.Range(1, 10).ToArray();

            Random rand = new Random();
            int tryToGuessNum = rand.Next(1, 10);

            Console.WriteLine("Part 1: Enter a number between 1 and 10");
            int guess = int.Parse(Console.ReadLine());

            try
            {
                doWork(guess, tryToGuessNum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Part 2: Guess my number, human plays.");
            Console.WriteLine();
            Console.ReadKey();

            //int[] list1000 = Enumerable.Range(1, 1001).ToArray();
            Random rand1000 = new Random();

            int tryToWin = rand1000.Next(1, 1000);
            Console.WriteLine("Enter a number between 1 and 1000");
            int guesslarge = int.Parse(Console.ReadLine());

            try
            {
                do1000Work(guesslarge, tryToWin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Part 3: Guess my number, computer plays.");
            Console.ReadKey();
            Console.WriteLine($"Is your number 500?");
            Console.WriteLine("Please enter 1 if my number is too high, 2 if my number is too low, or 0 if I got it right.");
            int compguess = 500;
            int x = 500;
            try
            {
                doGuessing(compguess, x);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private static int doGuessing(int compguess, int x)
        {
            int myinput = int.Parse(Console.ReadLine());
            if (myinput == 1)
            {
                x = (x / 2);
                compguess = compguess - x;
                Console.WriteLine($"What about {compguess}?");
                return doGuessing(compguess, x);
            }
            else if (myinput == 2)
            {
                x = (x / 2);
                compguess = x + compguess;
                Console.WriteLine($"What about {compguess}?");
                return doGuessing(compguess, x);
            }
            else
            Console.WriteLine("Alright! Thank you for playing with me.");
            return myinput = 0;

        }

        private static int doWork(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("You've got it!");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Sorry. Try again!");
                int attempt = int.Parse(Console.ReadLine());
                return doWork(attempt, y);
        }
        private static int do1000Work(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Great job! You've beat the computer!");
                Console.ReadKey();
                //System.Environment.Exit(1);
            }
            else if (x > y)
            {
                Console.WriteLine("Your number is too high! Try again.");
                int attempt1 = int.Parse(Console.ReadLine());
                return do1000Work(attempt1, y);
            }
            else if (x < y)
            {
                Console.WriteLine("Your number is too low! Try again.");
                int attempt = int.Parse(Console.ReadLine());
                return do1000Work(attempt, y);
            }
            else
                throw new InvalidOperationException("Enter a number");
                return do1000Work(x, y);
        }
    }
}
