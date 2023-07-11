using Lab_12._2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            double n2 = double.Parse(Console.ReadLine());

            Calculation calobj = new Calculation();
            calobj.setValues(n1, n2);

            Console.Write("Sum : " + calobj.getAddition());
            Console.Write("Sub : " + calobj.getSubstraction());
            Console.Write("Mul : " + calobj.getMultiplication());
            Console.Write("Div : " + calobj.getDivision());
        }
    }
}
