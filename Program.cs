using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //begin first triangle
            for (int i = 1; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("==================");
            //begin first triangle
            for (int i = 4; i > 0; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
