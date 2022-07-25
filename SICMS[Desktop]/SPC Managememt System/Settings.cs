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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM Settings";
            var x = Config.DAL(Query);
            if (x.Rows.Count > 0)
            {
                TxtServer.Text = x.Rows[0][0].ToString();
                Txtname.Text = x.Rows[0][2].ToString();
                TxtPath.Text = x.Rows[0][5].ToString();
                TxtUsername.Text = x.Rows[0][4].ToString();
                TxtPassword.Text = x.Rows[0][3].ToString();
                TxtPort.Text = x.Rows[0][1].ToString();
                validate();
            }
        }

        bool validate()
        {
            if (TxtServer.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (Txtname.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtUsername.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtPath.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            } else if (TxtPort.Text == "")
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

        private void BtnTest_Click(object sender, EventArgs e)
        {
            LblTest.Visible = true;
            LblTest.Text = "";
            if (DB.GetInstance().ConnectionTest())
            {
                LblTest.Text = "Database Connection Test is successful";
                LblTest.ForeColor = Color.FromArgb(54, 216, 54);
            }
            else
            {
                LblTest.Text = "Database Connection Test is unsuccessful";
                LblTest.ForeColor = Color.FromArgb(241, 67, 80);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string Query = "SELECT * FROM Settings";
                var x = new List<string>();
                if (Config.DAL(Query).Rows.Count > 0)
                {
                    Query = "UPDATE Settings SET Server = @a, Port = @b, Database = @c, Password = @d, Username = @e, Images_Path = @f";
                    x.Add(TxtServer.Text);
                    x.Add(TxtPort.Text);
                    x.Add(Txtname.Text);
                    x.Add(TxtPassword.Text);
                    x.Add(TxtUsername.Text);
                    x.Add(TxtPath.Text);
                }
                else
                {
                    Query = "INSERT INTO Settings(Server, Port, Database, Password, Username, Images_Path) VALUES ( @a, @b, @c, @d, @e, @f )";
                    x.Add(TxtServer.Text);
                    x.Add(TxtPort.Text);
                    x.Add(Txtname.Text);
                    x.Add(TxtPassword.Text);
                    x.Add(TxtUsername.Text);
                    x.Add(TxtPath.Text);
                }
                Config.DAL(Query, x);
                MessageBox.Show("Settings saved!", "SICMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtServer.Text = "";
            Txtname.Text = "";
            TxtPath.Text = "";
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPort.Text = "";
            this.Close();
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            var openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TxtPath.Text = openFileDialog.SelectedPath + "\\";
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void TxtServer_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void Txtname_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtPath_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
