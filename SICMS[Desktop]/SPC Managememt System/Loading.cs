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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            Config config = new Config();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void CheckUsers_Tick(object sender, EventArgs e)
        {
            User a = new User();
            string Query = "SELECT * FROM user_account WHERE account_type = 'Inspection Director'";
            var x = DB.GetInstance().Query(Query);
            if (x.Rows.Count > 0)
            {                
                CheckUsers.Stop();
                Authentication login = new Authentication();
                this.Hide();
                login.Show();                
            }
            else
            {
                CheckUsers.Stop();
                FirstSignUp frm = new FirstSignUp();
                this.Hide();
                frm.Show();                
            }
        }
    }
}
