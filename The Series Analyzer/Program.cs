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
        static void menue()
        {
            Console.WriteLine("enter a letter a - j");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    inputSeries();
                    menue();
                    break;
                case "b":
                    display();
                    menue();
                    break;
                case "c":
                    reversed();
                    menue();
                    break;
                case "d":
                    sorted();
                    menue();
                    break;
                case "e":
                    MaxValue();
                    menue();
                    break;
                case "f":
                    MinValue();
                    menue();
                    break;
                case "g":
                    Average();
                    menue();
                    break;
                case "h":
                    numElements();
                    menue();
                    break;
                case "i":
                    sum();
                    menue();
                    break;
                case "j":
                    break;
                default:
                    Console.WriteLine("invalid syntax");
                    menue();
                    break;
            }
        }
    }
}
