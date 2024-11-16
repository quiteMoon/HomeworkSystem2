using System;
using System.Text;

namespace HomeworkSystem2
{
    internal class Program
    {
        static int[] data = new int[10000];
        static int max = int.MinValue;
        static int min = int.MaxValue;
        static double average = 0;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Завдання 3
            /*Console.Write("Введіть початок діапазону: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введіть кінець діапазону: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість потоків: ");
            int numberOfThreads = int.Parse(Console.ReadLine());

            int rangePerThread = (end - start + 1) / numberOfThreads;
            int remainder = (end - start + 1) % numberOfThreads;

            for (int i = 0; i < numberOfThreads; i++)
            {
                int threadStart = start + i * rangePerThread;
                int threadEnd = (i == numberOfThreads - 1) ? end : threadStart + rangePerThread - 1;

                Thread numberThread = new Thread(() => displayNumbers(threadStart, threadEnd));
                numberThread.Start();

                numberThread.Join();
            }

            Console.WriteLine("Усі потоки завершили роботу.");*/

            //Завдання 4
            /*Random rand = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 10001);
            }

            Thread maxThread = new Thread(FindMax);
            Thread minThread = new Thread(FindMin);
            Thread averageThread = new Thread(FindAverage);

            maxThread.Start();
            minThread.Start();
            averageThread.Start();

            maxThread.Join();
            minThread.Join();
            averageThread.Join();

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Average: {average:F2}");*/

            //Завдання 5
            /*int n = 10;
            Thread fibonacciThread = new Thread(() => GenerateFibonacci(n));

            fibonacciThread.Start();

            fibonacciThread.Join();

            Console.WriteLine("Потік завершив виконання.");*/
        }

        static void displayNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }

        static void FindMax()
        {
            max = data.Max();
        }

        static void FindMin()
        {
            min = data.Min();
        }

        static void FindAverage()
        {
            average = data.Average();
        }

        static void GenerateFibonacci(int n)
        {
            long a = 0, b = 1;
            Console.WriteLine($"Fibonacci Sequence (first {n} numbers):");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                long temp = a;
                a = b;
                b = temp + b;

                Thread.Sleep(500);
            }
        }
    }
}
