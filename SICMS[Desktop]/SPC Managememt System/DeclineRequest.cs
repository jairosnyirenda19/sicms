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
    public partial class DeclineRequest : Form
    {
        private string request_id;
        public DeclineRequest(string request_id)
        {
            InitializeComponent();
            this.request_id = request_id;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (RichTextReason.Text != "")
            {
                var x = new Dictionary<string, string>();
                x.Add("status","declined");
                DB.GetInstance().Update("requested_inspection", "request_id",request_id,x);

                var z = new[] {"request_id", "=", request_id };
                DB.GetInstance().Get("requested_inspection", z);
                var y = DB.GetInstance().dt;

                string Query = "SELECT c.customer_id FROM sowing_report s, customer c WHERE s.customer_id = c.customer_id AND s.sowing_id = @a";
                z = new[] { y.Rows[0]["sowing_id"].ToString() };
                var customer_details = DB.GetInstance().GetCompoundCondition(Query, z);

                string msg = "Your request for an inspection, "+ y.Rows[0]["inspection_type"].ToString()+", has been denied. REASON(S) being :: "+RichTextReason.Text+"";
                x = new Dictionary<string, string>();
                x.Add("customer_id", customer_details.Rows[0]["customer_id"].ToString());
                x.Add("content", msg);
                x.Add("date", DateTime.Now.ToShortDateString());
                DB.GetInstance().Insert("timeline", x);
                this.Close();
            }
            else
                MessageBox.Show("Please give the reason for declining the request","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
