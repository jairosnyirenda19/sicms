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
    public partial class FirstSignUp : Form
    {
        Inspector i = new Inspector();
        private string password;
        private string salt;
        public FirstSignUp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void BtnSaveSIO_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var x = new[] { "username", "=", TxtUname.Text };
                DB.GetInstance().Get("user_account", x);
                var d = DB.GetInstance().dt;
                if ((bool)(d.Rows.Count == 0))
                {
                    var z = new Dictionary<string, string>();
                    z.Add("firstname", TxtFname.Text);
                    z.Add("last_name", TxtLname.Text);
                    z.Add("email", TxtEmail.Text);
                    z.Add("contact", TxtContact.Text);
                    DB.GetInstance().Insert("user", z);

                    string Query = "SELECT `employee_id` FROM `user` ORDER BY `employee_id` DESC LIMIT 1";
                    d = DB.GetInstance().Query(Query);

                    z = new Dictionary<string, string>();
                    z.Add("employee_id", d.Rows[0][0].ToString());
                    z.Add("username", TxtUname.Text);
                    z.Add("password", password);
                    z.Add("salt", salt);
                    z.Add("account_type", CmbAccount.Text);
                    DB.GetInstance().Insert("user_account", z);
                    MessageBox.Show("Seed Inspector Officer add successfully!", "SICMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Authentication login = new Authentication();
                    this.Hide();
                    login.Show();
                    
                }
            }
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
            else if (CmbAccount.Text == "")
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

        private void BtnGenePS_Click(object sender, EventArgs e)
        {
            string x = i.Generate("password").ToLower();
            salt = i.GetSalt(i.Generate(""));
            password = i.Hash(x, salt);
            TxtPassword.Text = x;
            validate();
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
    }
}
