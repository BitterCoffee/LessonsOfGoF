using SimpleFactory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var operate = "+";
            var cal = CalculateFactory.CreateCalculate(operate);
            cal.NumA = 1d;
            cal.NumB = 2d;
            Console.WriteLine("Calculate: {0}{1}{2}={3}", cal.NumA, operate, cal.NumB, cal.GetResult());

            operate = "-";
            cal = CalculateFactory.CreateCalculate(operate);
            cal.NumA = 3d;
            cal.NumB = 4d;
            Console.WriteLine("Calculate: {0}{1}{2}={3}", cal.NumA, operate, cal.NumB, cal.GetResult());


            operate = "*";
            cal = CalculateFactory.CreateCalculate(operate);
            cal.NumA = 5d;
            cal.NumB = 6d;
            Console.WriteLine("Calculate: {0}{1}{2}={3}", cal.NumA, operate, cal.NumB, cal.GetResult());
            
            operate = "/";
            cal = CalculateFactory.CreateCalculate(operate);
            cal.NumA = 7d;
            cal.NumB = 8d;
            Console.WriteLine("Calculate: {0}{1}{2}={3}", cal.NumA, operate, cal.NumB, cal.GetResult());
            
            operate = "^";
            cal = CalculateFactory.CreateCalculate(operate);
            cal.NumA = 9d;
            cal.NumB = 10d;
            Console.WriteLine("Calculate: {0}{1}{2}={3}", cal.NumA, operate, cal.NumB, cal.GetResult());

            Console.ReadLine();
        }
    }
}
