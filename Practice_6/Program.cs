using System;

namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Console.Write("Ведите размер массива=");
            //int n = int.Parse(Console.ReadLine());
            //int[] omas = new int[n];
            //Random rnd = new Random();
            //for(int i=0; i<n; i++)
            //{
            //    omas[i] = rnd.Next(1, 80);
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            //int max = omas[0];
            //int min = omas[0];
            //for(int i=0; i<n; i++)
            //{
            //    if (omas[i]>max)
            //    {
            //        max = omas[i];
            //    }
            //    if (omas[i]<min)
            //    {
            //        min = omas[i];
            //    }
            //}
            //Console.WriteLine($"max={max}\t min={min}");
            //int p = max;
            //max = min;
            //min = p;
            //Console.WriteLine($"Обмененный max={max}, а min={min}");
            //Console.ReadKey();


            //Задание 2
            //Random rnd = new Random();
            //double[] omas = new double[12] { 1.6, 8.4, 9.5, 3.9, 1.2, 4.4, 3.5, 7.3, 2.6, 5.5, 9.9, 3.8 };
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"Обычные элементы: omas[{i}]= {omas[i] + ""}");
            //}
            //Array.Sort(omas);
            //Array.Reverse(omas);
            //Console.WriteLine();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"Элементы в порядке убвания: omas[{i}]={omas[i] + ""}");
            //}
            //double max = omas[0];
            //double min = omas[0];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] > max)
            //    {
            //        max = omas[i];
            //    }
            //    if (omas[i] < min)
            //    {
            //        min = omas[i];
            //    }
            //}
            //double sum = 0;
            //sum += min + max;
            //Console.WriteLine($" max={max}\t min={min}\t sum(max+min)={sum}");
            //Console.ReadKey();

            //Задание 3
            int[] omas = new int[14] { 1, 9, 2, 8, 3, 7, 4, 6, 5, 11, 14, 13,10,12 };
            int p;
            for(int i=0; i<omas.Length; i++)
            {
                for(int j=i+1; j<omas.Length-1; j++)
                {
                    if (omas[i] > omas[j])
                    {
                        p = omas[i];
                        omas[i] = omas[j];
                        omas[j] = p;
                    }
                }
            }
            for(int i=0; i<omas.Length; i++)
            {
                Console.WriteLine(omas[i]);
            }
            Console.ReadKey();

        }
    }
}
