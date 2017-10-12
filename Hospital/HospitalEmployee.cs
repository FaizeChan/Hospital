using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class HospitalEmployee
    {
        private string name;
        private int employeeNumber;

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int EmployeeNumber
        {
            get { return this.EmployeeNumber; }
            set { this.EmployeeNumber = value; }
        }

        public HospitalEmployee()
        {

        }

        public HospitalEmployee(string name, int employeeNumber)
        {
            this.name = name;
            this.employeeNumber = employeeNumber;
        }
    }
}
