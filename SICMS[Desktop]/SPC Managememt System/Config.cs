using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace SPC_Managememt_System
{
    class Config
    {
        public static string server = string.Empty;
        public static int port = 0;
        public static string database = string.Empty;
        public static string username = string.Empty;
        public static string password = string.Empty;
        public static string ImgPath = string.Empty;
        public static string ConnectionString = string.Empty;
        public static List<string> paramsnames = new List<string>();

        public Config()
        {
            LoadConfig();
            if (paramsnames.Count == 0)
                AddParams();
            ConnectionString = "server=" + server + ";database=" + database + ";username=" + username + ";password=" + password + "";
            //ConnectionString = "server=" + server + ";port=" + port + ";database=" + database + ";username=" + username + ";password=" + password + "";
        }

        public static DataTable DAL(string Query)
        {
            string strConnect = "Data Source=Config.db; Version=3; Compress=True;";
            DataTable dataTable = new DataTable();
            List<string> parameter = new List<string>();
            try
            {
                SQLiteConnection _connection = new SQLiteConnection(strConnect);
                SQLiteCommand command = _connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = Query;
                SQLiteDataAdapter liteDataAdapter = new SQLiteDataAdapter(command);
                liteDataAdapter.Fill(dataTable);
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            return dataTable;
        }

        public static DataTable DAL(string Query, List<string> data)
        {
            string strConnect = "Data Source=Config.db; Version=3; Compress=True;";
            DataTable dataTable = new DataTable();
            List<string> parameter = new List<string>();
            try
            {
                SQLiteConnection _connection = new SQLiteConnection(strConnect);
                SQLiteCommand command = _connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = Query;
                parameter = SQLEscapeCharacters(Query);
                for (int i = 0; i < parameter.Count; i++)
                {
                    command.Parameters.Add(parameter[i], data[i]);
                }
                SQLiteDataAdapter liteDataAdapter = new SQLiteDataAdapter(command);
                liteDataAdapter.Fill(dataTable);
                command.Parameters.Clear();
                parameter.Clear();
                data.Clear();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
            return dataTable;
        }

        private static List<string> SQLEscapeCharacters(string Query)
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
        public static void settingUpDatabase()
        {
            string Query = string.Empty;
            Query = "CREATE TABLE Settings(Server Text, Port Integer, Database Text, Password Text, Username Text, Images_Path Text)";
            DAL(Query);

        }

        private void LoadConfig()
        {
            string Query = "SELECT * FROM Settings";
            DataTable dt = DAL(Query);
            if (dt.Rows.Count > 0)
                foreach (DataRow item in dt.Rows)
                {
                    server = item["Server"].ToString();
                    port = Int32.Parse(item["Port"].ToString());
                    database = item["Database"].ToString();
                    password = item["Password"].ToString();
                    username = item["Username"].ToString();
                    ImgPath = item["Images_Path"].ToString();
                }
        }

        public static void AddParams()
        {
            paramsnames.Add("@a");
            paramsnames.Add("@b");
            paramsnames.Add("@c");
            paramsnames.Add("@d");
            paramsnames.Add("@e");
            paramsnames.Add("@f");
            paramsnames.Add("@g");
            paramsnames.Add("@h");
            paramsnames.Add("@i");
            paramsnames.Add("@j");
            paramsnames.Add("@k");
            paramsnames.Add("@l");
            paramsnames.Add("@m");
            paramsnames.Add("@n");
            paramsnames.Add("@o");
            paramsnames.Add("@p");
            paramsnames.Add("@q");
            paramsnames.Add("@r");
            paramsnames.Add("@s");
            paramsnames.Add("@t");
            paramsnames.Add("@u");
            paramsnames.Add("@v");
            paramsnames.Add("@w");
            paramsnames.Add("@x");
            paramsnames.Add("@y");
            paramsnames.Add("@z");
            paramsnames.Add("@aa");
            paramsnames.Add("@bb");
            paramsnames.Add("@cc");
            paramsnames.Add("@dd");
            paramsnames.Add("@ee");
            paramsnames.Add("@ff");
            paramsnames.Add("@gg");
            paramsnames.Add("@hh");
            paramsnames.Add("@ii");
            paramsnames.Add("@jj");
            paramsnames.Add("@kk");
            paramsnames.Add("@ll");
            paramsnames.Add("@mm");
            paramsnames.Add("@nn");
            paramsnames.Add("@oo");
            paramsnames.Add("@pp");
            paramsnames.Add("@qq");
            paramsnames.Add("@rr");
            paramsnames.Add("@ss");
            paramsnames.Add("@tt");
            paramsnames.Add("@uu");
            paramsnames.Add("@vv");
            paramsnames.Add("@ww");
            paramsnames.Add("@xx");
            paramsnames.Add("@yy");
            paramsnames.Add("@zz");
        }
    }
}
