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
    public partial class SIO_Card : UserControl
    {
        public SIO_Card()
        {
            InitializeComponent();
        }

        #region

        private string position;
        private string fname;
        private string lname;
        private string contact;
        private string email;
        private string username;

        public string Postion { get { return position; } set { position = value; LblPositon.Text = value; } }
        public string Fname { get { return fname; } set { fname = value; LblFirstname.Text = value; } }
        public string Lname { get { return lname; } set { lname = value; LblLastname.Text = value; } }
        public string Contact { get { return contact; } set { contact = value; LblContact.Text = value; } }
        public string Email { get { return email; } set { email = value; LblEmail.Text = value; } }
        public string Username { get { return username; } set { username = value; LblUsername.Text = value; } }

        #endregion
    }
}
