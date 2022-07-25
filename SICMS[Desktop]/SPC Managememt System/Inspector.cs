using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Managememt_System
{
    class Inspector : User
    {
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public DataTable GetSIOs(string Table = null, string[] Condition = null, string Query = null)
        {
            return base.GetUsers(Table, Condition, Query);
        }

        public bool InsertSIO(Dictionary<string, string> x = null, string Query = null, string Table = null)
        {
            return base.InsertSIOs(x, Query, Table);
        }

        public string Generate(string signature)
        {
            return base.GenerateRand(signature);
        }

        public string GetSalt(string salt)
        {
            return base.SymmetricKeyAlgorithm(salt);
        }

        public string Hash(string x, string z)
        {
            return base.ComputeSha256Hash(x, z);
        }
    }
}
