using Lab_12.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee ID:");
            string empID = Console.ReadLine();

            Console.WriteLine("Enter employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter employee Destination:");
            string empDestination = Console.ReadLine();

            Employee empobj = new Employee();

            empobj.setempID(empID);
            empobj.setempName(empName);
            empobj.setempDestination(empDestination);

            Console.WriteLine("Hello" + empobj.getempName() + "Your Employee is" + empobj.getempID() + "and you are a" + empobj.getempDestination());
        }
    }
}
