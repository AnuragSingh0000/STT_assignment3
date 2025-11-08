using System;

namespace Lab9
{
    public class Arithmetics
    {
        private double a, b;
        public Arithmetics(double x, double y)
        {
            a = x;
            b = y;
        }
        public double Add()
        {
            return a + b;
        }
        public double Subtract()
        {
            return a - b;
        }
        public double Multiply()
        {
            return a * b;
        }
        public double Divide()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }


    public class Loops_Factorial
    {
        public void PrintUsingFor()
        {
            Console.WriteLine("Numbers (for loop):");
            for (int i = 1; i <= 10; i++)
                Console.Write(i + " ");
            Console.WriteLine("\n");
        }

        public void PrintUsingForEach()
        {
            Console.WriteLine("Numbers (foreach loop):");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine("\n");
        }

        public long Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        public void UserInputLoop()
        {
            string input;
            do
            {
                Console.Write("Enter a number to find factorial (or type 'exit' to quit): ");
                input = Console.ReadLine();

                if (input.ToLower() != "exit")
                {
                    if (int.TryParse(input, out int number))
                    {
                        Console.WriteLine($"Factorial of {number} = {Factorial(number)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }

            } while (input.ToLower() != "exit");
        }
    }

    public class Sort_MatMul
    {
        public void printarr(int[] arr)
        {
            Console.WriteLine("Array elements:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void printmat(int[,] mat)
        {
            Console.WriteLine("Matrix elements:");
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void printRowMajor(int[,] mat)
        {
            Console.WriteLine("Matrix in Row-Major Order:");
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public void printColumnMajor(int[,] mat)
        {
            Console.WriteLine("Matrix in Column-Major Order:");
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        
        public int[,] MatMul(int[,] A, int[,] B)
        {
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);
            int r2 = B.GetLength(0);
            int c2 = B.GetLength(1);

            if (c1 != r2)
            {
                throw new InvalidOperationException("Matrix dimensions are not compatible for multiplication.");
            }

            int[,] C = new int[r1, c2];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < c1; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }
    }
}
