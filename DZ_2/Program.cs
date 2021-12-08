using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main()
        {
            int j = 3;
            int i1 = 1;
            int z = 1;
            int x = 3;
            int c = 5;
            int c1 = 1;

            while (j==3)
            {
                if (i1 != 3)
                {
                    Console.Write(' ');
                    i1++;
                }
                else
                {
                    Console.Write('*');
                    j--;
                    Console.WriteLine();
                }
            }

            while(j==2)
            {
                if (z == 1)
                {
                    Console.Write(' ');
                    z++;
                }
                else
                {
                    while(z<5)
                    {
                        Console.Write('*');
                        z++;
                        j--;
                    }
                }
            }

            Console.WriteLine();

            while (x == 3)
            {
                if (c1 <= c)
                {
                    Console.Write('*');
                    c1++;
                }
            }
        }
    }
}
