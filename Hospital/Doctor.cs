using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctor : HospitalEmployee
    {
        private string specialtyArea;

        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        public Doctor()
        {

        }

        public Doctor (string name, int employeeNumber, string specialtyArea)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

    }
}
