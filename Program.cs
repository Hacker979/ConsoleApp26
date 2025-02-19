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
            
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < b)
                {
                    b = mas[i];
                }
            }
        }
        static void Mas()
        {
            int[] mas = new int[5] {4, 5, 6, 3, 7 } ;
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