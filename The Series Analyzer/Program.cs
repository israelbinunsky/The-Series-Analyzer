using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Series_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }
        static string[] isFull(string[] args)
        {
            if (args.Length < 3)
            {
                args = Console.ReadLine().Split(' ');
            }
            return args;
        }
        

    }
}
