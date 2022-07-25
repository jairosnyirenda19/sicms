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
    public partial class ListSowingReport : UserControl
    {
        public ListSowingReport()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        #region Properties
        private string sowing_id;
        private string name;
        private string crop;
        private string _date;
        private string _status;

        public string Sowing_Id
        {
            get { return sowing_id; }
            set { sowing_id = value;}
        }
        [Category("Custom Propeties")]
        public string ClientName
        {
            get { return name; }
            set { name = value; LblName.Text = value; }
        }

        [Category("Custom Propeties")]
        public string Crop
        {
            get { return crop; }
            set { crop = value; LblSeed.Text = value; }
        }

        [Category("Custom Propeties")]
        public string _Date
        {
            get { return _date; }
            set { _date = value; LblDate.Text = value; }
        }

        [Category("Custom Propeties")]
        public string _Status
        {
            get { return _status; }
            set { _status = value; LblState.Text = value; }
        }
        #endregion


        private void WireAllControls(Control cont)
        {
            foreach (Control control in cont.Controls)
            {
                control.DoubleClick += Control_DoubleClick;
                if (control.HasChildren)
                    WireAllControls(control);
            }
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void ListSowingReport_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(241, 243, 237);
        }

        private void ListSowingReport_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }


    }
}
