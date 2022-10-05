using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class lab4
    {
        static void Main(string[] args)
        {
            int mid = -1;
            while (mid != 0)
            {
                Console.WriteLine("Номер задания:\n1\n2\n0 - выход");
                try
                {
                    mid = Convert.ToInt16(Console.ReadLine());

                }
                catch
                {
                    Console.Clear();
                    continue;
                }

                Console.Clear();
                switch (mid)
                {
                    case 1:
                        {
                            Console.WriteLine("----№1----\nВведите n: ");
                            int n = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Введите m: ");
                            int m = Convert.ToInt16(Console.ReadLine());
                            Random random = new Random();

                            int[] oneArray = new int[n];
                            int[,] twoArray = new int[n, m];

                            Console.Write("Одномерный массив: \n");
                            for (int i = 0; i < n; i++)
                            {
                                int k = random.Next(-10, 10);
                                oneArray[i] = Convert.ToInt32(func(n, k));
                            }
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write(oneArray[i] + "\t");
                            }

                            Console.WriteLine("\n\nДвумерный массив: \n");
                            for (int y = 0; y < twoArray.GetLength(0); y++)
                            {
                                for (int x = 0; x < twoArray.GetLength(1); x++)
                                {
                                    int k = random.Next(10);
                                    twoArray[y, x] = Convert.ToInt32(func(n, k));
                                    Console.Write(twoArray[y, x] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey(); Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("----№3----\nВведите размер массива (n): ");
                            int n_ = Convert.ToInt16(Console.ReadLine());

                            int[,] myArray = new int[n_, n_];
                            Random rand = new Random();

                            for (int y = 0; y < myArray.GetLength(0); y++)
                            {
                                for (int x = 0; x < myArray.GetLength(1); x++)
                                {
                                    myArray[y, x] = rand.Next(100);
                                }
                            }

                            Console.WriteLine("Массив: \n");
                            for (int y = 0; y < myArray.GetLength(0); y++)
                            {
                                for (int x = 0; x < myArray.GetLength(1); x++)
                                {
                                    Console.Write(myArray[y, x] + "\t");
                                }
                                Console.WriteLine();
                            }

                            int sum = 0;
                            for (int i = 0; i < n_; i++)
                            {
                                sum += myArray[i, i];
                            }
                            Console.WriteLine("\nСумма гл.диагонали = " + sum);
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                }


            }
            static double func(int n, int k)
            {
                return (Math.Pow(5, k)) / Math.Sqrt(n * (n + 1));
            }
        }
    }
}