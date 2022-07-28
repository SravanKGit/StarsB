using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsB
{
    internal class Program   
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number \n");
            int MAX = int.Parse(Console.ReadLine());

            int i, j;
            
            for (i = 1; i <= MAX; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            for (i = MAX; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


