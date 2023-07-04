using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ObjStudent = new Student();
            ObjStudent.MyMethod();
            ObjStudent.MyInfo();

            Console.ReadKey();
        }
    }
}
