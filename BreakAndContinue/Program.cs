using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // code below will skip(continue) all odd numbers and will stop(break) if i == 20
            for (int i = 1; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                else if (i == 20)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
