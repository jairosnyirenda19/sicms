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
    public partial class SetAppointment : Form
    {
        private string request_id;
        public SetAppointment(string request_id)
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
            var z = new[] { "request_id", "=", request_id };
            DB.GetInstance().Get("requested_inspection", z);
            var y = DB.GetInstance().dt;

            string Query = "SELECT * FROM sowing_report s, customer c WHERE s.customer_id = c.customer_id AND s.sowing_id = @a";
            z = new[] { y.Rows[0]["sowing_id"].ToString() };
            var d = DB.GetInstance().GetCompoundCondition(Query, z);

            Query = "SELECT crop_name" +
               "FROM crop, sowing_report" +
               "WHERE crop.crop_id = sowing_report.crop_id" +
               "AND sowing_id = " + y.Rows[0]["sowing_id"].ToString() + "";
            var x = DB.GetInstance().Query(Query);
            string crop = (x.Rows.Count > 0) ? x.Rows[0]["crop_name"].ToString() : "";

            Query = "SELECT class_name" +
                           "FROM class, sowing_report" +
                           "WHERE class.class_id = sowing_report.class_id" +
                           "AND sowing_id = " + y.Rows[0]["sowing_id"].ToString() + "";
            x = DB.GetInstance().Query(Query);
            string category = (x.Rows.Count > 0) ? x.Rows[0]["crop_name"].ToString() : "";


            string Msg = "Your request for seed inspection for "+crop+": "+category+" sown on "+ d.Rows[0]["date_of_sowing"].ToString() + " has been approved. You have an appointment for inspection.";
            var m = new Dictionary<string,string>();
            m.Add("customer_id", d.Rows[0]["customer_id"].ToString());
            m.Add("title", "Field Inspection");
            m.Add("content",Msg);
            m.Add("date_of_appointment", DateFormatFixing(DtDate.Value.ToShortDateString()));
            DB.GetInstance().Insert("appointment", m);

        }
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }
    }
}
