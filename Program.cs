using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Print(int[] mas,ref int b)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nминимальное = {b}");
        }
        static void Write(int[] mas, ref int b)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-10, 10);
                Console.WriteLine($"mas[{i}] = {mas[i]}");
                if (mas[i] < b)
                {
                    c = i
                    b = mas[i];
                }
            }
        }
        static void Mas()
        {
            int[] mas = new int[5];
            int b = mas[0];
            Write( mas, ref b);
            Print( mas, ref b);

        }
        static void Main(string[] args)
        {
            Mas();

            Console.ReadLine();
        }
    }
}