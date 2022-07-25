using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class SIOs : Form
    {
        Inspector i = new Inspector();
        private string password;
        private string salt;
        public SIOs()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (TxtFname.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtLname.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtContact.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtUname.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtPassword.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if(CmbAccount.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else
            {
                LblMsg.Text = "";
                return true;
            }
        }

        private void loadsios()
        {
            string Query = "SELECT * FROM user";
            var x = i.GetSIOs(null, null, Query);
            flowLayoutPanel1.Controls.Clear();
            var card = new SIO_Card[x.Rows.Count];
            if (x.Rows.Count > 0)
            {
                for (int i = 0; i < x.Rows.Count; i++) {
                    Query = "SELECT a.username, a.account_type FROM user u, user_account a WHERE u.employee_id = a.employee_id AND u.employee_id = @a";
                    var z = new[] { x.Rows[i][0].ToString() };
                    var u = DB.GetInstance().GetCompoundCondition(Query, z);

                    card[i] = new SIO_Card();
                    card[i].Postion = u.Rows[0][1].ToString().ToUpper();
                    card[i].Username = u.Rows[0][0].ToString();
                    card[i].Fname = x.Rows[i][1].ToString();
                    card[i].Lname = x.Rows[i][2].ToString();
                    card[i].Email = x.Rows[i][3].ToString();
                    card[i].Contact = x.Rows[i][4].ToString();

                    card[i].Width = (flowLayoutPanel1.Width - 25);
                    flowLayoutPanel1.Controls.Add(card[i]);
                }
            }
        }

        private void loadassign()
        {
            string Query = "SELECT * FROM customer";
        }
        private void SIOs_Load(object sender, EventArgs e)
        {
            loadsios();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveSIO_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var x = new[] { "username", "=", TxtUname.Text };
                var d = i.GetSIOs("user_account", x);
                if ((bool)(d.Rows.Count == 0))
                {
                    var z = new Dictionary<string, string>();
                    z.Add("firstname", TxtFname.Text);
                    z.Add("last_name",TxtLname.Text);
                    z.Add("email",TxtEmail.Text);
                    z.Add("contact",TxtContact.Text);
                    i.InsertSIO(z, null, "user");

                    string Query = "SELECT `employee_id` FROM `user` ORDER BY `employee_id` DESC LIMIT 1";
                    d = i.GetSIOs(null,null, Query);

                    z = new Dictionary<string, string>();
                    z.Add("employee_id", d.Rows[0][0].ToString());
                    z.Add("username", TxtUname.Text);
                    z.Add("password",password);
                    z.Add("salt", salt);
                    z.Add("account_type", CmbAccount.Text);
                    i.InsertSIO(z, null, "user_account");
                    MessageBox.Show("Seed Inspector Officer add successfully!","SICMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }        
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
            TxtFname.Text = "";
            TxtLname.Text = "";
            TxtEmail.Text = "";
            TxtUname.Text = "";
            TxtContact.Text = "";
            validate();
        }

        private void BtnGenePS_Click(object sender, EventArgs e)
        {
            string x = i.Generate("password").ToLower();
            salt = i.GetSalt(i.Generate(""));
            password = i.Hash(x, salt);
            TxtPassword.Text = x;
            validate();
        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtLname_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtUname_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void CmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void DataGridAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

            }
        }
    }
}
