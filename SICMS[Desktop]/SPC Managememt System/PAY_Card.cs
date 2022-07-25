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
    public partial class PAY_Card : UserControl
    {
        public PAY_Card()
        {
            InitializeComponent();
        }

        #region

        private string mode;
        private string name;
        private string num;

        public string Mode { get { return mode; } set { mode = value; LblMode.Text = value; } }
        public string _Name { get { return name; } set { name = value; LblName.Text = value; } }
        public string Num { get { return num; } set { num = value; LblNum.Text = value; } }

        #endregion
    }
}
