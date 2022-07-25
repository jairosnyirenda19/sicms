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
    public partial class Inspection_flowing_stage : UserControl
    {
        public Inspection_flowing_stage()
        {
            InitializeComponent();
        }

        #region Properties
        private string inspector;
        private string certification_no;
        private DateTime date;
        private string description;
        private string isolation_distance_maintained;
        private string removal_offtype_proper_rouging;
        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; RichTextRemarks.Text = value; }
        }

        public string Removal_Offtype_Proper_Rouging
        {
            get { return removal_offtype_proper_rouging; }
            set { removal_offtype_proper_rouging = value; LblOfftypeRemoval.Text = value; }
        }
        public string Isolation_Distance_Maintained
        {
            get { return isolation_distance_maintained; }
            set { isolation_distance_maintained = value; LblVerifyIsolationDistance.Text = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; LblDescription.Text = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; LblDateConducted.Text = value.ToShortDateString(); }
        }
        public string Certification_No
        {
            get { return certification_no; }
            set { certification_no = value; LblCertificationNo.Text = value; }
        }

        public string Inspector
        {
            get { return inspector; }
            set { inspector = value; LblInspector.Text = value; }
        }
        #endregion
    }
}
