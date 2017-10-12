using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Receptionist : HospitalEmployee
    {
        private string department;
        private bool phoneDuty;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool PhoneDuty
        {
            get { return this.phoneDuty; }
            set { this.phoneDuty = value; }
        }

        public Receptionist()
        {

        }

        public Receptionist(string name, int employeeNumber, string department, bool phoneDuty)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.department = department;
            this.phoneDuty = phoneDuty;            
        }
    }
}
