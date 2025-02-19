using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Print(int[] mas)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
        }
        static void Write(int a, int[] mas)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"mas[{i}] = {i}");
                mas[i] = i;
            }
        }
        static void Mas()
        {
            int a = int.Parse(Console.ReadLine());
            int[] mas = new int[a];
            Write(a, mas);
            Print(mas);

        }
        static void Main(string[] args)
        {
            Mas();

            Console.ReadLine();
        }
    }
}