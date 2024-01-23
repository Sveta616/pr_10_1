using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_10
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Random R = new Random();
                Console.WriteLine("Введите кол-во строк");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Исходный массив");
                int[,] m = new int[n, t];
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {

                        m[i, j] = R.Next(-2, 10);
                        Console.Write(m[i, j] + " ");


                    }
                    Console.WriteLine();
                }

                Console.WriteLine("-----");
                Console.WriteLine("Введите а");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    int count1 = 0;
                    for (int j = 0; j < m.GetLength(1); j++)
                    {

                        if (m[i, j] % a == 0)
                        {
                            count1++;
                        }


                    }
                    Console.WriteLine($"кол-во кратных {a} в строке= {count1}");
                }
                Console.WriteLine("-----");
                Console.WriteLine("Введите b");
                int b = int.Parse(Console.ReadLine());
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    int count2 = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {

                        if (m[i, j] % b == 0)
                        {
                            count2++;
                        }


                    }
                    Console.WriteLine($"кол-во кратных {b} в столбце= {count2}");
                }
                Console.WriteLine("-----");
                Console.WriteLine("Введите k1");
                int k1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите k2");
                int k2 = int.Parse(Console.ReadLine());
                double ot = 1;
                for (int i = k1 - 1; i < k2; i++)
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (m[i, j] < 0)
                        {
                            Console.WriteLine(m[i, j]);
                            ot *= m[i, j];
                        }
                    }
                }
                Console.WriteLine("произвед отриц= " + Math.Round(ot, 2));
            }
            catch
            {
                Console.WriteLine("Введите символ");
            }
        

                    Console.ReadKey();
        }
    }
}
