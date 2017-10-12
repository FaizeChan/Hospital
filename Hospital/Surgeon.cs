using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Surgeon : Doctor
    {
        private bool operation;

        public bool Operation
        {
            get { return this.Operation; }
            set { this.Operation = value; }
        }

        public Surgeon(string name, int employeeNumber, string specialtyArea, bool Operation)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.SpecialtyArea = specialtyArea;
            this.Operation = operation;
        }


    }
}
