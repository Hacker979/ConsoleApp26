using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Print(int[] mas, int min, ref int b)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nчисел больше {min} = {b}");
        }
        static void Write(int[] mas, int min, ref int b)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= min)
                {
                    b++;
                }
            }
        }
        static void Mas()
        {
            int min = int.Parse(Console.ReadLine());
            int b = 0;
            int[] mas = new int[5] {4, 5, 6, 3, 7 } ;
            Write( mas, min, ref b);
            Print(mas, min, ref b);

        }
        static void Main(string[] args)
        {
            Mas();

            Console.ReadLine();
        }
    }
}