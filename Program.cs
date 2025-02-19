using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void mas(int a)
        {
            int[] mas = new int[a];
            for (int i = 0; i<a; i++)
            {
                Console.Write($"mas[{i}] = ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            mas(int.Parse(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
