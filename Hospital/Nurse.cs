using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : HospitalEmployee
    {
        private string department;
        private int numberOfPatients;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public int NumberOfPatients
        {
            get { return this.NumberOfPatients; }
            set { this.NumberOfPatients = numberOfPatients; }
        }

        public Nurse()
        {

        }

        public Nurse(string name, int employeeNumber, string department)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.department = department;
        }

    }
}
