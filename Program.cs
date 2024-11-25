using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            for(int start = 1; start <= n; start++)
            {
                for(int row=start; row<=n; row++)
                {
                    for(int column = start; column <= row; column++)
                    {
                        Console.Write(column);
                    }
                    Console.WriteLine();
                    
                }
               
            }
            Console.ReadKey();
        }

    }
}
