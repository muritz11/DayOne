using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCapIndex
{
    internal class Program
    {
        static int[] CapIndices(string txt)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsUpper(txt[i]))
                {
                    indices.Add(i);
                }
            }

            int[] indicesArray = indices.ToArray();
            return indicesArray;

        }


        static void Main(string[] args)
        {
            int[] helloIndices = CapIndices("Hello World");
            Console.WriteLine("Capital letters were found in indexes: ");
            foreach (int i in helloIndices)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
