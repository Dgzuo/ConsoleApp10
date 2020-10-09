using System;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число x0");
                int x0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число x1");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число y0");
                int y0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число y1");
                int y1 = int.Parse(Console.ReadLine());
                if (Math.Sqrt(x0 * x0 + y0 * y0) == Math.Sqrt(x1 * x1 + y1 * y1)) Console.WriteLine("Они равны");
                else if (Math.Sqrt(x0 * x0 + y0 * y0) > Math.Sqrt(x1 * x1 + y1 * y1)) Console.WriteLine("x0,y0 ближе к нулю");
                else if (Math.Sqrt(x0 * x0 + y0 * y0) < Math.Sqrt(x1 * x1 + y1 * y1)) Console.WriteLine("x1,y1 ближе к нулю");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }