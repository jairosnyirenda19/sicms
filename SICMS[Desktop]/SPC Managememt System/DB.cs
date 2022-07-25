using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    class DB
    {
        
        public DataTable dt = new DataTable();
        private static DB getInstance = null;

        public DB()
        {

        }

        public static DB GetInstance()
        {
            if(getInstance == null)
                getInstance = new DB();
            return getInstance;
        }

        public bool ConnectionTest()
        {
            var _connection = new MySqlConnection(Config.ConnectionString);
            try
            {
                _connection.Open();
                _connection.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }



        public DataTable GetCompoundCondition(string Query, string[] _data)
        {
            List<string> paramater = _data.OfType<string>().ToList();
            return DAL(Query, paramater);
        }

        public bool Get(string table, string[] where)
        {
            return this.action("SELECT *", table, where);
        }

        public bool Delete(string table, string[] where)
        {
            return this.action("DELETE", table, where);
        }

        public bool Update(string table, string col, string id, Dictionary<string, string> fields)
        {
            if (fields.Count > 0)
            {
                Dictionary<string, string>.KeyCollection keys = fields.Keys;
                List<string> tables = new List<string>();
                List<string> data = new List<string>();
                string set = "";
                int x = 1;

                foreach (string key in keys)
                    tables.Add(key);

                for (int i = 0; i < tables.Count; i++)
                {
                    data.Add(fields[tables[i]]);
                    set += tables[i] + " = " + Config.paramsnames[i];
                    if (x < tables.Count)
                        set += ", ";
                    x++;
                }

                string sql = "UPDATE " + table + " SET " + set + " WHERE " + col + " = " + id + "";
                dt = DAL(sql, data);
                return true;
            }
            return false;
        }

        public bool Insert(string table, Dictionary<string, string> fields)
        {
            if (fields.Count > 0)
            {
                var keys = fields.Keys;
                var tables = new List<string>();
                var data = new List<string>();
			    string values = "";
			    string tbl = "";
                int x = 1 ,y = 1;

                foreach (string key in keys)                
                    tables.Add(key);

                for (int i = 0; i < fields.Count; i++)
                {
                    values += Config.paramsnames[i];
                    if (x < fields.Count)
                        values += ", ";
                    x++;
                }

                for (int i = 0; i < tables.Count; i++)
                {
                    data.Add(fields[tables[i]]);
                    tbl += tables[i];
                    if (y < tables.Count)
                        tbl += ", ";
                    y++;
                }                
			    string sql = "INSERT INTO " + table + " (" + tbl + ") VALUES ( "+ values +" )";
                this.dt = this.DAL(sql, data);
                return true;               
            }
            return false;
        }

        private bool action(string action, string table, string[] where)
        {
            if (where.Length == 3)
            {
                string[] operators = new[] { "=", ">", "<", ">=", "<=" };
                string field = where[0];
                string opt = where[1];
                string value = where[2];

                if (operators.Contains(opt))
                {
                    string sql = action + " FROM " + table + " WHERE " + field + " " +opt+  " @a";
                    string[] val = new[] { value };
                    List<string> data = val.OfType<string>().ToList();
                    this.dt = this.DAL(sql, data);
                    return true;                    
                }
            }
            return false;
        }

        private DataTable DAL(string Query, List<string> data)
        {
            DataTable dataTable = new DataTable();
            List<string> parameter = new List<string>();
            try
            {
                MySqlConnection _connection = new MySqlConnection(Config.ConnectionString);
                MySqlCommand command = _connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = Query;
                parameter = SQLEscapeCharacters(Query);
                for (int i = 0; i < parameter.Count; i++)
                {
                    command.Parameters.AddWithValue(parameter[i], data[i]);
                    //MessageBox.Show(parameter[i] +" "+ data[i]);
                }
                MySqlDataAdapter liteDataAdapter = new MySqlDataAdapter(command);
                liteDataAdapter.Fill(dataTable);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            return dataTable;
        }

        public DataTable Query(string query)
        {
            return dt = DAL(query);
        }

        private DataTable DAL(string Query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection _connection = new MySqlConnection(Config.ConnectionString);
                MySqlCommand command = _connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = Query;
                MySqlDataAdapter liteDataAdapter = new MySqlDataAdapter(command);
                liteDataAdapter.Fill(dataTable);
            }
            catch (MySqlException e)
            {
                //MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            return dataTable;
        }

        private List<string> SQLEscapeCharacters(string Query)
        {
            List<string> paramater = new List<string>();
            foreach (String word in Query.Split(' ', '(', ')', '\'', '%'))
            {
                if (!word.Equals(""))
                {
                    if (word.Substring(0, 1) == "@")
                    {
                        StringBuilder builder = new StringBuilder();
                        foreach (char z in word)
                        {
                            if (!z.Equals(',') && !z.Equals('(') && !z.Equals(')') && !z.Equals('\'') && !z.Equals('%'))
                                builder.Append(z);
                        }
                        paramater.Add(builder.ToString());
                        builder.Clear();
                    }
                }
            }
            return paramater;
        }
    }
}
