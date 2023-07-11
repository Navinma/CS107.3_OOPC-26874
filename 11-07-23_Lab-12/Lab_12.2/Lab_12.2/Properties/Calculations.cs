using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._2.Properties
{
    internal class Calculations
    {
        private double num1;
        private double num2;

        public void setValue(double n1,double n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public double getAddition()
        {
            return num1 + num2;
        }
        public double getSubstraction()
        {
            return num1 - num2;
        }
        public double getMultiplication()
        {
            return num1 * num2;
        }
        public double getDivision()
        {
            return num1 / num2;
        }
    }
}
