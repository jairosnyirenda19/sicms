using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Managememt_System
{
    class Director : User
    {
        private string employeeId;
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
    }
}
