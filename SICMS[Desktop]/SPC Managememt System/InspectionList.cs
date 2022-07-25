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
    public partial class InspectionList : Form
    {
        private string sowing_id;
        public InspectionList(string sowing_id)
        {
            InitializeComponent();
            this.sowing_id = sowing_id;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Inspection Data

        private int Inspections()
        {
            var Condition = new[] { "sowing_id", "=", sowing_id };
            DB.GetInstance().Get("pre_flowering_inspection", Condition);
            var pre_flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id };
            DB.GetInstance().Get("flowering_inspection", Condition);
            var flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id };
            DB.GetInstance().Get("post_flowering_inspection", Condition);
            var post_flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id };
            DB.GetInstance().Get("harvest_inspection", Condition);
            var harvest = DB.GetInstance().dt;

            int total = 0;

            if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0 && harvest.Rows.Count > 0)
            {
                total = 4;
                lblpreflowering.Enabled = true;
                lblflowering.Enabled = true;
                lblpostflowering.Enabled = true;
                lblharvest.Enabled = true;
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0)
            {
                total = 3;
                lblpreflowering.Enabled = true;
                lblflowering.Enabled = true;
                lblpostflowering.Enabled = true;
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0)
            {
                total = 2;
                lblpreflowering.Enabled = true;
                lblflowering.Enabled = true;
            }
            else if (pre_flowering.Rows.Count > 0)
            {

                total = 1;
                lblpostflowering.Enabled = true;
            }
            else
            {
                return 0;
            }
            return total;
        }

        private Inspection_pre_flowing_stage PreFlowering()
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("pre_flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_pre_flowing_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var a = DB.GetInstance().dt;

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var b = DB.GetInstance().dt;

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Pre Flowering Inspection";
                page.SiteLocation = "N/A";
                page.Seed_Source = x.Rows[0]["source"].ToString();
                page.Acreage = x.Rows[0]["acreage"].ToString();
                page.Uniform = x.Rows[0]["uniformity"].ToString();
                page.Proper_Rouging = x.Rows[0]["rouging"].ToString();
                page.OffType = x.Rows[0]["off_type"].ToString();
                page.RemovalOffType = x.Rows[0]["removal"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
            }
            return page;
        }

        private Inspection_flowing_stage Flowering()
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_flowing_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var a = DB.GetInstance().dt;

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var b = DB.GetInstance().dt;

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Flowering Inspection";
                page.Isolation_Distance_Maintained = x.Rows[0]["isolation_maintain"].ToString();
                page.Removal_Offtype_Proper_Rouging = x.Rows[0]["off_type_removal"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
            }
            return page;
        }

        private Inspection_post_flowering_stage PostFlowering()
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("post_flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_post_flowering_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var a = DB.GetInstance().dt;

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var b = DB.GetInstance().dt;

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Post Flowering Inspection";
                page.ConfirmationIssuesTakenCare = x.Rows[0]["issues_taken_care"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
            }
                return page;
        }

        private Inspection_harvest_stage Harvest()
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("harvest_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_harvest_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var a = DB.GetInstance().dt;

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                DB.GetInstance().GetCompoundCondition(Query, z);
                var b = DB.GetInstance().dt;

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Harvest Inspection";
                page.Maturity = x.Rows[0]["maturity"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
            }
            return page;
        }
        #endregion


        private void Lblpreflowering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sowing_Report report = new Sowing_Report();
            report.PopulateInspections(PreFlowering());
            this.Hide();
        }

        private void Lblflowering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sowing_Report report = new Sowing_Report();
            report.PopulateInspections(Flowering());
            this.Hide();
        }

        private void Lblpostflowering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sowing_Report report = new Sowing_Report();
            report.PopulateInspections(PostFlowering());
            this.Hide();
        }

        private void Lblharvest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sowing_Report report = new Sowing_Report();
            report.PopulateInspections(Harvest());
            this.Hide();
        }

        private void InspectionList_Load(object sender, EventArgs e)
        {
            lblTotalInspection.Text = "Inspections Conducted: "+Inspections()+"";
        }
    }
}
