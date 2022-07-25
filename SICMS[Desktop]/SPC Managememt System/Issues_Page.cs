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
    public partial class Issues_Page : Form
    {
        private Dictionary<string, string> Issues;
        private List<string> Info;
        public Issues_Page(Dictionary<string, string> Issues, List<string> Info)
        {
            InitializeComponent();

            this.Issues = Issues;
            this.Info = Info;

            //this.Info.Add(this.Issues.Count.ToString());
            //this.Info.Add("4");
            //this.Info.Add("90");
        }

        private void Issues_Page_Load(object sender, EventArgs e)
        {
            lblTotIssues.Text = string.Format("{0} {1}","Total Issues:", Info[0]);
            lblnumInspections.Text = "From ("+Info[1]+") Inspection(s)";
            lblpercent.Text = "Analysis Percentage: "+Info[2]+"%";

            if ((bool)(Issues.Count > 0))
            {
                var title = Issues.Keys;
                var ttl = new List<string>();
                foreach (string key in title)
                    ttl.Add(key);

                for (int i = 0; i < Issues.Count; i++)
                {
                    string tl = ttl[i];
                    string content = Issues[ttl[i]];

                    Label t = lblcontent(i, tl, true);
                    FlowPnlIssues.Controls.Add(t);

                    Label c = lblcontent(i, content, false);
                    FlowPnlIssues.Controls.Add(c);
                }
            }
        }

        private Label lblcontent(int num, string content, bool title)
        {
            var label = new Label();
            label.Text = content;
            label.ForeColor = Color.Black;
            label.BackColor = FlowPnlIssues.BackColor;
            if(title)
                label.Font = new Font("Arial", 13, FontStyle.Bold);
            else
                label.Font = new Font("Arial", 11, FontStyle.Regular);
            label.Width = (FlowPnlIssues.Width - 40);
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Margin = new Padding(15);
            return label;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
