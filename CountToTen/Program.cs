using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nUsing For Loop");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\nUsing For Loop with question");
            Console.WriteLine("How far do you want to count? ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\nUsing For Loop Counting by 2");

            for (int i = 0; i <= count; i = i + 2)
            {
                Console.WriteLine(i.ToString());
            }

            int j = 0;

            Console.WriteLine("\nUsing while loop");
            while(j <= 10)
            {
                Console.WriteLine(j.ToString());
                j = j + 1;
            }
            Console.WriteLine("\nPost test while loop");
            j = 0;

            do
            {
                Console.WriteLine(j.ToString());
                j++;
            } while (j <= 10);
            Console.ReadLine();

        }
    }
}
