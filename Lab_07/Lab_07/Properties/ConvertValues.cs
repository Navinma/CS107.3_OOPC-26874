using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07.Properties
{
    internal class ConvertValues
    {
        public double kmTOm(double km)
        {
            double m = km * 1000;
            Console.WriteLine(m.ToString() + "m");
            return m;
        }
    }
}
