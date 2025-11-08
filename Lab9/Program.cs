using System;


namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the part to run:");
            int part = int.Parse(Console.ReadLine());
            switch (part)
            {
                case 1:
                    Part1();
                    break;
                case 2:
                    Part2();
                    break;
                case 3:
                    Part3();
                    break;
                default:
                    Console.WriteLine("Invalid part number.");
                    break;
            }
        }

        static void Part1()
        {
            Console.WriteLine("Executing Part 1...");
            Console.WriteLine("Enter the first number:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double y = double.Parse(Console.ReadLine());

            Arithmetics pair = new Arithmetics(x, y);
            double sum = pair.Add();
            double difference = pair.Subtract();
            double product = pair.Multiply();
            double quotient = pair.Divide();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            if (sum % 2 == 0)
            {
                Console.WriteLine("The sum is even.");
            }
            else
            {
                Console.WriteLine("The sum is odd.");
            }
        }
        static void Part2()
        {
            Console.WriteLine("Executing Part 2...");
            Loops_Factorial loopFact = new Loops_Factorial();
            loopFact.PrintUsingFor();
            loopFact.PrintUsingForEach();
            loopFact.UserInputLoop();
            Console.WriteLine("Enter a number to compute its factorial:");
            int n = int.Parse(Console.ReadLine());
            loopFact.Factorial(n);
            Console.WriteLine($"Factorial of {n} is {loopFact.Factorial(n)}");

        }

        static void Part3()
        {
            Console.WriteLine("Executing Part 3...");
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements:");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Sort_MatMul ops = new Sort_MatMul();
            ops.BubbleSort(arr);
            Console.WriteLine("Sorted array:");
            ops.printarr(arr);

            Console.WriteLine("Enter dimensions of matrix 1 (rows and columns):");
            int[] d1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Enter dimensions of matrix 2 (rows and columns):");
            int[] d2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Enter each row of matrix 1:");
            int[,] m1 = new int[d1[0], d1[1]];
            for (int i = 0; i < d1[0]; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < d1[1]; j++)
                {
                    m1[i, j] = row[j];
                }
            }
            Console.WriteLine("Enter each row of matrix 2:");
            int[,] m2 = new int[d2[0], d2[1]];
            for (int i = 0; i < d2[0]; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < d2[1]; j++)
                {
                    m2[i, j] = row[j];
                }
            }

            Console.WriteLine("Matrix 1:");
            ops.printmat(m1);
            Console.WriteLine("Matrix 2:");
            ops.printmat(m2);

            ops.printRowMajor(m1);
            ops.printColumnMajor(m2);
            Console.WriteLine("Matrix after multiplication:");
            ops.printmat(ops.MatMul(m1, m2));

        }
    }
}

