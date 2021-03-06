using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string 1");
            string str1 = Console.ReadLine();

            Console.WriteLine("\nPlease enter string 2");
            string str2 = Console.ReadLine();

            string op1 = string.Empty;
            string op2 = string.Empty;

            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();

            for(int i = 0; i <= str1Arr.Length - 1; i++)
            {
                char currElem = str1Arr[i];

                if(!str2.Contains(currElem))
                {
                    op1 += currElem;
                }
            }

            for (int i = 0; i <= str2Arr.Length - 1; i++)
            {
                char currElem = str2Arr[i];

                if (!str1.Contains(currElem))
                {
                    op2 += currElem;
                }
            }

            Console.WriteLine("\nop1 : " + op1);
            Console.WriteLine("\nop2 : " + op2);

            Console.ReadLine();
        }
    }
}
