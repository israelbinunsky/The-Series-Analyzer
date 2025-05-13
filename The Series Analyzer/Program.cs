using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Series_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menue();
        }

        static int[] intArray()
        {
            string[] args = { null };
            while (args == null || args.Length < 3)
            {
                Console.WriteLine("enter 3 numbers:");
                args = Console.ReadLine().Split(' ');
            }
            int[] nums = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                int.TryParse(args[i], out int num);
                nums[i] = num;
            }
            while (nums == null || nums.Length < 3)
            { intArray(); }
            return nums;
        }


        static void menue(int[] ints = null)
        {
            if (ints == null || ints.Length < 3) { ints = intArray(); }
            Console.WriteLine("enter a letter a - j");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    ints = inputSeries();
                    menue(ints);
                    break;
                case "b":
                    display(ints);
                    menue(ints);
                    break;
                case "c":
                    reversed(ints);
                    menue(ints);
                    break;
                case "d":
                    sorted(ints);
                    menue(ints);
                    break;
                case "e":
                    maxValue(ints);
                    menue(ints);
                    break;
                case "f":
                    minValue(ints);
                    menue(ints);
                    break;
                case "g":
                    average(ints);
                    menue(ints);
                    break;
                case "h":
                    numElements(ints);
                    menue(ints);
                    break;
                case "i":
                    sum(ints);
                    menue(ints);
                    break;
                case "j":
                    break;
                default:
                    Console.WriteLine("invalid syntax");
                    menue(ints);
                    break;
            }
        }

        static int[] inputSeries()
        {
            int[] ints = intArray();
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            return ints;
        }

        static void display(int[] ints)
        {
            foreach (int i in ints)
            { Console.Write($"{i} "); }
        }

        static void reversed(int[] ints)
        {
        for (int i = ints.Length - 1; i >= 0; i--)
            { Console.Write($"{ints[i]} "); }
        }

        static void sorted(int[] ints)
        {
            Array.Sort(ints);
            foreach (int i in ints)
            { Console.Write($"{i} "); }
        }

        static void maxValue(int[] ints)
        {
            int maxNum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > ints[maxNum] ) { maxNum = i; }
            }
            Console.WriteLine(ints[maxNum]);
        }

        static void minValue(int[] ints)
        {
            int minNum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < ints[minNum]) { minNum = i; }
            }
            Console.WriteLine(ints[minNum]);
        }

        static void average(int[] ints)
        {
            int s = 0;
            foreach (int i in ints)
            { s += i; }
            Console.WriteLine(s / ints.Length);
        }

        static void numElements(int[] ints)
        {   int l = 0;
            for (int i = 0; i < ints.Length; i++)
            { l++; }
            Console.WriteLine(l);
        }

        static void sum(int[] ints)
        {
            int s = 0;
            foreach (int i in ints)
            {  s += i; }
            Console.WriteLine(s);
        }

    }
}
