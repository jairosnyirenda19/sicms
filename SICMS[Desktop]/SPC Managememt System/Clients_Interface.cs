using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class Clients_Interface : UserControl
    {
        public Clients_Interface()
        {
            InitializeComponent();
        }

        private void Clients_Interface_Load(object sender, EventArgs e)
        {
            _Load(null, null, "SELECT * FROM customer");
            _LoadYears();
        }

        public static void _LoadNecessity()
        {
            Clients_Interface @interface = new Clients_Interface();
            @interface._Load(null, null, "SELECT * FROM customer");
            @interface._LoadYears();
        }

        private void _LoadYears()
        {
            var z = Client.LoadYears();
            ComboYearFliter.Items.Clear();
            for (int i = 0; i < z.Count; i++)
                ComboYearFliter.Items.Add(z[i]);
        }

        private void _Load(string Table = null, string[] Condition = null, string Query = null)
        {
            var x = new DataTable();
            if (Condition != null && Query != null)
                x = DB.GetInstance().GetCompoundCondition(Query, Condition);
            else
                x = Client.GetClients(null, null, Query);
            DataGridClients.Rows.Clear();
            for (int i = 0; i < x.Rows.Count; i++)
            {
                int row = DataGridClients.Rows.Add();
                string[] ConditionTwo = new[] { "customer_id", "=", x.Rows[i][0].ToString() };
                string name = x.Rows[i][1].ToString() + " " + x.Rows[i][2].ToString();
                DataGridClients.Rows[row].Cells[0].Value = name;
                DataGridClients.Rows[row].Cells[1].Value = x.Rows[i][3].ToString();
                DataGridClients.Rows[row].Cells[2].Value = x.Rows[i][4].ToString();
                DataGridClients.Rows[row].Cells[3].Value = x.Rows[i][5].ToString();
                DataGridClients.Rows[row].Cells[4].Value = x.Rows[i][6].ToString().Split(' ')[0];
                DataGridClients.Rows[row].Cells[5].Value = Client.Getcount("sowing_report", ConditionTwo);                
            }
        }

        private void ComboYearFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string QueryOne = "SELECT * FROM customer WHERE(SELECT EXTRACT(YEAR FROM Joined) = @a);";
            string QueryTwo = "SELECT * FROM customer";
            if (ComboYearFliter.Text == "All*")
                _Load(null, null, QueryTwo);
            else
            {
                string[] x = new[] { ComboYearFliter.Text };
                _Load(null, x, QueryOne);
            }
        }

        private void TxtSearchClients_TextChanged(object sender, EventArgs e)
        {
            if (ComboSearchBy.Text == "")
            {
                MessageBox.Show("Please select what to [search by]* in order to search","SPCMS",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Column = (ComboSearchBy.Text.Split(' ').Length == 2) ? ComboSearchBy.Text.Split(' ')[0] + ComboSearchBy.Text.Split(' ')[1]: ComboSearchBy.Text.Split(' ')[0];
            string QueryOne = "SELECT * FROM customer WHERE(SELECT EXTRACT(YEAR FROM Joined) = @a) AND "+Column+" LIKE @b";
            string QueryTwo = "SELECT * FROM customer WHERE "+Column+" LIKE @a";

            if (ComboYearFliter.Text == "" || ComboYearFliter.Text == "All*")
            {
                string[] x = new[] { "%" + TxtSearchClients.Text + "%" };
                _Load(null, x, QueryTwo);
            }
            else if (ComboYearFliter.Text != "" && ComboYearFliter.Text != "All*")
            {
                string[] x = new[] { ComboYearFliter.Text, "%" + TxtSearchClients.Text + "%" };
                _Load(null, x, QueryOne);
            }
            else { }
        }
    }
}
