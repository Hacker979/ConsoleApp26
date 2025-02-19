using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Print(int[] mas, ref int b)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"Четных = {b}");
        }
        static void Write(int a, int[] mas, ref int b)
        {
            Random rand = new Random();
            
            for (int i = 0; i < a; i++)
            {
                mas[i] = rand.Next(-10, 10);
                Console.WriteLine($"mas[{i}] = {mas[i]}");

                if (mas[i] % 2 == 0)
                {
                    b++;
                }
            }
        }
        static void Mas()
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int[] mas = new int[a];
            Write(a, mas, ref b);
            Print(mas, ref b);

        }
        static void Main(string[] args)
        {
            Mas();

            Console.ReadLine();
        }
    }
}
