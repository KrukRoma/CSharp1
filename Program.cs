namespace С_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            Console.Write("Enter a six-digit number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 100000 && number <= 999999)
            {
                int reversedNumber = 0;

                for (int i = 0; i < 6; i++)
                {
                    int digit = number % 10; 
                    reversedNumber = reversedNumber * 10 + digit; 
                    number /= 10; 
                }

                Console.WriteLine("Reversed number: " + reversedNumber);
            }
            else
            {
                Console.WriteLine("You did not enter a six-digit number.");
            }

            //4
            Console.Write("Enter the lower bound of the range: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound of the range: ");
            int upperBound = int.Parse(Console.ReadLine());

            if (lowerBound > upperBound)
            {
                Console.WriteLine("The lower bound must be less than or equal to the upper bound.");
                return;
            }

            Console.WriteLine($"Fibonacci numbers in the range {lowerBound} to {upperBound}:");
            PrintFibonacciInRange(lowerBound, upperBound);
        }

        static void PrintFibonacciInRange(int lowerBound, int upperBound)
        {
            int a = 0;
            int b = 1;

            if (a >= lowerBound && a <= upperBound)
                Console.Write(a + " ");
            if (b >= lowerBound && b <= upperBound)
                Console.Write(b + " ");

            int next = a + b;

            while (next <= upperBound)
            {
                if (next >= lowerBound)
                    Console.Write(next + " ");

                a = b;
                b = next;
                next = a + b;
            }
            Console.WriteLine();

            //5
            Console.Write("Enter the lower bound A (A < B): ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound B (A < B): ");
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("The lower bound A must be less than the upper bound B.");
                return;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            //6
            Console.Write("Enter the length of the line: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the fill character: ");
            char fillCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            Console.Write("Enter the direction (h for horizontal, v for vertical): ");
            char direction = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            if (direction == 'h')
            {
                DrawHorizontalLine(length, fillCharacter);
            }
            else if (direction == 'v')
            {
                DrawVerticalLine(length, fillCharacter);
            }
            else
            {
                Console.WriteLine("Invalid direction entered. Please enter 'h' for horizontal or 'v' for vertical.");
            }
        }

        static void DrawHorizontalLine(int length, char fillCharacter)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillCharacter);
            }
            Console.WriteLine(); 
        }

        static void DrawVerticalLine(int length, char fillCharacter)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillCharacter);
            }
        }
    }
}
