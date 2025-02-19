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
            Random rand = new Random();
            for (int i = 0; i < a; i++)
            {
                mas[i] = rand.Next(-10, 10);
                Console.WriteLine($"mas[{i}] = {mas[i]}");
                
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
