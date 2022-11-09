using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskString
{
    internal class Program
    {
        static string MaskString(string txt)
        {
            string maskedTxt = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (i < txt.Length - 4)
                {
                    maskedTxt += "#";
                }
                else
                {
                    maskedTxt += txt[i];
                }
            }

            return maskedTxt;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string to mask: ");
            string input = Console.ReadLine();
            Console.Write(MaskString(input));
            Console.ReadLine();

        }
    }
}
