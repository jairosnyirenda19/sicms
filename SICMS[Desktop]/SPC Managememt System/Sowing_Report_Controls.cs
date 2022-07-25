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
    public partial class Sowing_Report_Controls : UserControl
    {
        private Standard x;
        private Sowing_Report_Page w;
        double percent;
        public Sowing_Report_Controls(Standard standard, Sowing_Report_Page report_Page)
        {
            InitializeComponent();
            x = standard;
            w = report_Page;

        }

        #region Properties
        private string sowing_id;
        public string Sowing_Id
        {
            get { return sowing_id; }
            set { sowing_id = value; }
        }
        #endregion

        void Analyze()
        {
            percent = x.RecommendedAction(Int32.Parse(sowing_id));
        }

        private void BtnActionRecommendation_Click(object sender, EventArgs e)
        {
            using (WaitFormDialog wait = new WaitFormDialog(Analyze))
            {
                wait.FormClosed += Wait_FormClosed;
                wait.ShowDialog();
            }

        }

        private void Wait_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (percent == 0)
            {
                MessageBox.Show("No Inspection Data Found for this client","SIMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var y = new List<string>();
            y.Add(x.MainIssues.Count.ToString());
            y.Add(x.TotalAnlysis.ToString());
            y.Add(percent.ToString());

            var z = new Issues_Page(x.MainIssues, y);
            Sowing_Report.InvokeOpenForm(z);
        }

        private void BtnGenerateCertificationNO_Click(object sender, EventArgs e)
        {
            var z = MessageBox.Show("Are you sure you want to grant certification to this sowing report ?", "SICMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (z == DialogResult.Yes)
                w.CertificationNo = (x.GenerateCertificationNumber(sowing_id));
        }

        private void BtnDisqualify_Click(object sender, EventArgs e)
        {
            var z = MessageBox.Show("Are you sure you want to disqualify this sowing report ?", "SICMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (z == DialogResult.Yes)
                x.Disqualify(sowing_id);
        }
    }
}
