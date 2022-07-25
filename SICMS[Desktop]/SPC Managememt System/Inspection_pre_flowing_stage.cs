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
    public partial class Inspection_pre_flowing_stage : UserControl
    {
        public Inspection_pre_flowing_stage()
        {
            InitializeComponent();
        }

        private void Inspection_pre_flowing_stage_Load(object sender, EventArgs e)
        {
            RichTextRemarks.ReadOnly = true;
        }

        #region Properties

        private string certification_no;
        private string inspector;
        private DateTime date;
        private string description;
        private string location;
        private string seed_source;
        private string acreage;
        private double isolation;
        private string uniform;
        private string proper_rouging;
        private string offtype;
        private string removalofftype;
        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; RichTextRemarks.Text = value; }
        }

        public string RemovalOffType
        {
            get { return removalofftype; }
            set { removalofftype = value; LblRemovalOffType.Text = value; }
        }

        public string OffType
        {
            get { return offtype; }
            set { offtype = value; LblOffType.Text = value; }
        }

        public string Proper_Rouging
        {
            get { return proper_rouging; }
            set { proper_rouging = value; LblProperRouging.Text = value; }
        }
        public string Uniform
        {
            get { return uniform; }
            set { uniform = value; LblUniformplantingRatio.Text = value; }
        }

        public double Isolation_Distance
        {
            get { return isolation; }
            set { isolation = value; LblIsolation.Text = value.ToString(); }
        }

        public string Acreage
        {
            get { return acreage; }
            set { acreage = value; LblVerifyAcreage.Text = value.ToString(); }
        }

        public string Seed_Source
        {
            get { return seed_source; }
            set { seed_source = value; LblVerifySeedSource.Text = value; }
        }

        public string  SiteLocation
        {
            get { return location; }
            set { location = value; LblVerifyLocation.Text = value; }
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
            set { inspector = value; LblInspectorAllocated.Text = value; }
        }

        #endregion
    }
}
