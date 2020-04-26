using System;

namespace writtenQuiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = { 8, 6, 7, 5, 3, 0, 9 };
            int x = int.MaxValue;
            foreach (var y in z) x = y < x ? y : x;

            Console.WriteLine($"Question 29: {x}");

            string[] arr = {
                "Jenny jenny who can I turn to",
                 "You give me something I can hold on to",
                "I know you'll think I'm like the others before",
                "Who saw your name and number on the wall"
                };
            int x20 = arr[arr.Length - 1].Split(' ')[5].Length;

            Console.WriteLine($"Question 20: {x20}");

            int[] numbers = new int[] { 8, 6, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 9 };
            int x23 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    x23++;
                }
            }
            Console.WriteLine($"Question 23: {x23}");

            int x24 = 867;
            int y24 = 5309;
            y24 = x24 + y24;
            x24 = y24 - x24;
            y24 = y24 - x24;
            Console.WriteLine($"Question 24: {x24}");

            int x25 = 0, y25 = 8675309;
            while (y25 > 1)
            {
                x25 *= 10;
                x25 += y25 % 10;
                y25 /= 10;
            }
            Console.WriteLine($"Question 25: {x25}");

            string y26 = "jenny";
            string x26 = "";
            int j26 = y26.Length;
            for (int i = 0; i < j26; i++)
            {
                x26 += y26[j26 - 1 - i];
            }

            Console.WriteLine($"Question 26: {x26}");

        }
    }
}
