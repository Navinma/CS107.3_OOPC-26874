using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12.Properties
{
    internal class Employee
    {
        private string empID;
        private string empName;
        private string empDestination;

        public void  setempID(string input)
        {
            empID = input;
        }
        public void setempName(string input)
        {
            empName = input;
        }
        public void setempDestination(string input)
        {
            empDestination = input;
        }
    }
}
