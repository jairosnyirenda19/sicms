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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void BtnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Time_Greeting_Tick(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() =>
            {
                this.BeginInvoke((Action)delegate () {
                    string[] dayTime = new string[3] { "Good Morning", "Good Afternoon", "Good Evening" };
                    string h = DateTime.Now.ToString("HH");
                    int AmPm = Int32.Parse(h);
                    if (AmPm <= 11)                    
                        LblGreetings.Text = string.Format("{0}", dayTime[0]);                    
                    else if (AmPm <= 17)                   
                        LblGreetings.Text = string.Format("{0}", dayTime[1]);                    
                    else                   
                        LblGreetings.Text = string.Format("{0}", dayTime[2]);                    
                });
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void BtnAuthentic_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Login(TxtUsername.Text, TxtPassword.Text))
            {
                var h = new _Home();
                this.Hide();
                h.Show();                
            }
            else
            {
                MessageBox.Show("Log in failed, please try again","SICMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
