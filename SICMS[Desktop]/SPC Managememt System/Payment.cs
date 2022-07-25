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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            loadmethods();
            loadmodes();
        }

        void loadmodes()
        {
            string Query = "SELECT * FROM payment_method";
            var x = DB.GetInstance().Query(Query);
            if (x.Rows.Count > 0)
            {
                for (int i = 0; i < x.Rows.Count; i++) {
                    CmbMode.Items.Add(x.Rows[i][1].ToString());
                }
            }
        }

        void loadmethods()
        {
            flowLayoutPanel1.Controls.Clear();
            string Query = "SELECT * FROM mobile_service";
            var x = DB.GetInstance().Query(Query);
            Query = "SELECT * FROM bank_service";
            var y = DB.GetInstance().Query(Query);
            int count = x.Rows.Count + y.Rows.Count;
            var card = new PAY_Card[count];

            if (y.Rows.Count > 0)
            {
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    card[i] = new PAY_Card();
                    card[i].Mode = "Bank Service";
                    card[i]._Name = y.Rows[i][1].ToString();
                    card[i].Num = y.Rows[i][2].ToString();
                    card[i].Cursor = Cursors.Hand;
                    card[i].Width = (flowLayoutPanel1.Width - 25);
                    flowLayoutPanel1.Controls.Add(card[i]);
                }
            }

            if (x.Rows.Count > 0)
            {
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    card[i] = new PAY_Card();
                    card[i].Mode = "Mobile Service";
                    card[i]._Name = x.Rows[i][1].ToString();
                    card[i].Num = x.Rows[i][2].ToString();
                    card[i].Cursor = Cursors.Hand;
                    card[i].Width = (flowLayoutPanel1.Width - 25);
                    flowLayoutPanel1.Controls.Add(card[i]);
                }
            }
        }

        bool validate()
        {
            if (CmbMode.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (Txtname.Text == "")
            {
                LblMsg.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else if (TxtNum.Text == "")
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

        bool validateMode()
        {
            if (TxtMode.Text == "")
            {
                LblMsg_One.Text = "All mandatory (*) fields should filled";
                return false;
            }
            else
            {
                LblMsg_One.Text = "";
                return true;
            }
        }

        private void BtnAddMode_Click(object sender, EventArgs e)
        {
            if (validateMode())
            {
                var x = new Dictionary<string, string>();
                x.Add("Method",TxtMode.Text);
                DB.GetInstance().Insert("payment_method", x);
                TxtMode.Text = "";
                MessageBox.Show("Mode Saved!", "SICMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadmodes();
            }
        }

        private void BtnCancelMode_Click(object sender, EventArgs e)
        {
            TxtMode.Text = "";
            validateMode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var x = new Dictionary<string, string>();
                if (CmbMode.Text == "Bank")
                {                    
                    x.Add("bank_name", Txtname.Text);
                    x.Add("account_number", TxtNum.Text);
                    DB.GetInstance().Insert("bank_service", x);
                }
                else
                {
                    x.Add("service_name", Txtname.Text);
                    x.Add("contact", TxtNum.Text);
                    DB.GetInstance().Insert("mobile_service", x);
                }
                loadmethods();
                BtnCancel_Click(sender, e);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CmbMode.Text = "";
            TxtNum.Text = "";
            Txtname.Text = "";
            validate();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void Txtname_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void TxtMode_TextChanged(object sender, EventArgs e)
        {
            validateMode();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }


    }
}
