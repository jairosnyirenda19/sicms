using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Managememt_System
{
    class Client : User
    {
        public Client()
        {

        }

        public void GetByYear()
        {

        }

        public static List<string> LoadYears()
        {
            var x = new List<string>();
            var builder = new StringBuilder();
            string y = string.Empty;
            string Query = "SELECT EXTRACT(YEAR FROM Joined) FROM customer ORDER BY Joined ASC LIMIT 1;";
            y = DB.GetInstance().Query(Query).Rows[0][0].ToString();

            foreach (char z in y)
                if (!z.Equals(','))
                    builder.Append(z);
            int a = Int32.Parse(builder.ToString());
            int counter = (DateTime.Now.Year - a);
            x.Add("All*");

            for (int i = 0; i <= counter; i++)
                if (DateTime.Now.Year > a)
                    if (i == 0)
                        x.Add(a.ToString());
                    else
                    {
                        a++;
                        x.Add(a.ToString());
                    }   
            
            return x;
        }

        public static DataTable GetClients(string Table = null, string[] Condition = null, string Query = null)
        {
            var client = new Client();
            return client.GetUsers(Table, Condition,Query);
        }

        public static int Getcount(string Table = null, string[] Condition = null, string Query = null)
        {
            var client = new Client();
            return client.Count(Table, Condition, Query);
        }

        protected override DataTable GetUsers(string Table = null, string[] Condition = null, string Query = null)
        {
            return base.GetUsers(Table, Condition, Query);
        }

        protected override int Count(string Table = null, string[] Condition = null, string Query = null)
        {
            return base.Count(Table, Condition, Query);
        }

    }
}
