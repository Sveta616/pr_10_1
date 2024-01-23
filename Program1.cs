using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {   //15
            try
            {
                int count = 0;
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

                        m[i, j] = R.Next(-2, 5);
                        Console.Write(m[i, j] + " ");


                    }
                    Console.WriteLine();
                }

                Console.WriteLine("-----");
                for (int i = 0; i < m.GetLength(0); i++)
                {

                    int sumot = 0;
                    for (int j = 0; j < m.GetLength(1); j++)
                    {


                        if (m[i, j] < 0)
                        {
                            count++;
                            sumot += m[i, j];

                        }


                    }
                    int sr = sumot / count;
                    Console.WriteLine("Сумма отриц элементов строки=" + sumot);
                    Console.WriteLine("Срзнач отриц элементов строки=" + sr);
                }
                Console.WriteLine("-----");
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    int sumot = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                    {


                        if (m[i, j] < 0)
                        {
                            count++;
                            sumot += m[i, j];

                        }


                    }
                    int sr = sumot / count;
                    Console.WriteLine("Сумма отриц элементов столбца=" + sumot);
                    Console.WriteLine("Срзнач отриц элементов столбца=" + sr);
                }

            }
            catch
            {
                Console.WriteLine("Введите символ");
            }





            Console.ReadKey();

        }
    }
}
