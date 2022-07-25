using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class Sowing_Report : Form
    {
        int mov, movX, movY;
        int ButtonClickCount = 0;
        int ButtonClickChecker = 0;
        string sowing_idx;
        private static Sowing_Report sowing = new Sowing_Report();

        public Sowing_Report()
        {
            InitializeComponent();
            BtnWindowSize.Iconimage = WindowSizeImageList.Images[0];
            BtnAppExit.Iconimage = WindowSizeImageList.Images[2];
            Populate();
            CmbInspection.Visible = false;            
        }


        private void sowing_report_page(string table, string[] z = null, string sowing_id = null)
        {
            DB.GetInstance().Get(table, z);
            var x = DB.GetInstance().dt;
            if (x.Rows.Count > 0)
            {
                Standard standard = new Standard();
                PnlActionControls.Controls.Clear();
                FlwSowingReport.Controls.Clear();
                var report_Page = new Sowing_Report_Page();
                var report_Controls = new Sowing_Report_Controls(standard, report_Page);

                var b = new[] { "", "", "" };
                string name = string.Empty;
                string crop = string.Empty;
                string certification = string.Empty;
                string variety = string.Empty;
                string seed_class = string.Empty;
                string bankAck = string.Empty;
                string banknameAcc = string.Empty;
                string mobileAcknowledgement = string.Empty;
                string transacationId = string.Empty;
                string mobileservicename = string.Empty;
                string bankDepositpath = string.Empty;
                string tagpath = string.Empty;
                string purchasebillpath = string.Empty;
                int inspectionConducted = 0;


                b = new[] { "customer_id", "=", x.Rows[0]["customer_id"].ToString() };
                DB.GetInstance().Get("customer", b);
                name = DB.GetInstance().dt.Rows[0]["Firstname"].ToString() + " " + DB.GetInstance().dt.Rows[0]["Lastname"].ToString();

                b = new[] { "crop_id", "=", x.Rows[0]["crop_id"].ToString() };
                DB.GetInstance().Get("crop", b);
                crop = DB.GetInstance().dt.Rows[0]["crop_name"].ToString();

                b = new[] { "certification_id", "=", x.Rows[0]["certification_id"].ToString() };
                DB.GetInstance().Get("certification_number", b);
                certification = (DB.GetInstance().dt.Rows.Count > 0) ? DB.GetInstance().dt.Rows[0]["certification_no"].ToString() : "N/A";

                inspectionConducted = Inspections(sowing_id);

                b = new[] { "variety_id", "=", x.Rows[0]["variety_id"].ToString() };
                DB.GetInstance().Get("variety", b);
                variety = DB.GetInstance().dt.Rows[0]["variety_name"].ToString();

                b = new[] { "class_id", "=", x.Rows[0]["class_id"].ToString() };
                DB.GetInstance().Get("class", b);
                seed_class = DB.GetInstance().dt.Rows[0]["class_name"].ToString() + " " + DB.GetInstance().dt.Rows[0]["genetic_purity"].ToString();

                b = new[] { "payment_id", "=", x.Rows[0]["payment_id"].ToString() };
                DB.GetInstance().Get("payment_details", b);
                if (DB.GetInstance().dt.Rows.Count > 0)
                {
                    var c = DB.GetInstance().dt;
                    bankAck = (c.Rows[0]["bank_id"].ToString() != "") ? "Yes" : "No";
                    bankDepositpath = (c.Rows[0]["bank_deposit_slip"].ToString() != "") ? Config.ImgPath + c.Rows[0]["bank_deposit_slip"].ToString():"";
                    if (bankAck.Equals("Yes"))
                    {
                        b = new[] { "bank_id", "=", c.Rows[0]["bank_id"].ToString() };
                        DB.GetInstance().Get("bank_service", b);
                        banknameAcc = DB.GetInstance().dt.Rows[0]["bank_name"].ToString() + " - " + DB.GetInstance().dt.Rows[0]["account_number"].ToString();
                        mobileAcknowledgement = "No";
                        mobileservicename = "Service: N/A";
                        transacationId = "Trans ID: N/A";
                    }
                    else
                    {
                        b = new[] { "service_id", "=", c.Rows[0]["service_id"].ToString() };
                        DB.GetInstance().Get("mobile_service", b);
                        banknameAcc = "Bank: N/A";
                        mobileAcknowledgement = "Yes";
                        mobileservicename = DB.GetInstance().dt.Rows[0]["service_name"].ToString() +": "+ DB.GetInstance().dt.Rows[0]["contact"].ToString();
                        transacationId = c.Rows[0]["transaction_id"].ToString();
                    }
                }

                report_Page.Sowing_id = sowing_id;
                report_Page.Clientname = name;
                report_Page.Crop = crop;
                report_Page.CertificationNo = (certification != "" || certification != null) ? certification : "N/A";
                report_Page.CountInspections = inspectionConducted;
                report_Page.Variety = variety;
                report_Page.Acreage = Int32.Parse(x.Rows[0]["acreage"].ToString());
                report_Page._Location = "N/A";
                report_Page.Seed_Class = x.Rows[0]["acreage"].ToString();
                report_Page.Seed_Class = seed_class;
                report_Page.Quantity = Int32.Parse(x.Rows[0]["quantity_per_acrea"].ToString());
                report_Page.Sowing_Date = Convert.ToDateTime(x.Rows[0]["date_of_sowing"].ToString());
                report_Page.Source = x.Rows[0]["seed_source"].ToString();
                report_Page.Tag_Number = x.Rows[0]["tag_number"].ToString();
                report_Page.PurchaseBillNo = x.Rows[0]["purchase_bill_no"].ToString();
                report_Page.Date_Seeds_Bought = Convert.ToDateTime(x.Rows[0]["date_of_purchase"].ToString());
                report_Page.BankAcknowledgement = bankAck;
                report_Page.Bankname = banknameAcc;
                report_Page.MobileAcknowledgement = mobileAcknowledgement;
                report_Page.Servicename = mobileservicename;
                report_Page.Transcation_Id = transacationId;


                report_Controls.Sowing_Id = x.Rows[0]["sowing_id"].ToString();

                Sowing_Report_Page.path_deposit = (bankDepositpath != "") ? bankDepositpath : "";
                Sowing_Report_Page.path_tag = (x.Rows[0]["tagSrc"].ToString() != "") ? Config.ImgPath + x.Rows[0]["tagSrc"].ToString() : "";
                Sowing_Report_Page.path_bill = (x.Rows[0]["purchaseBill"].ToString() != "") ? Config.ImgPath + x.Rows[0]["purchaseBill"].ToString() : "";
                report_Controls.Height = PnlActionControls.Height;
                report_Page.Width = (FlwSowingReport.Width - 25);
                FlwSowingReport.Controls.Add(report_Page);
                PnlActionControls.Controls.Add(report_Controls);
            }
        }

        private int Inspections(string sowing_id)
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

            CmbInspection.Items.Clear();
            CmbInspection.Text = "Select Inspection Type";
            CmbInspection.Visible = true;
            if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0 && harvest.Rows.Count > 0)
            {
                CmbInspection.Items.Add("Pre Flowering Inspection");
                CmbInspection.Items.Add("Flowering Inspection");
                CmbInspection.Items.Add("Post Flowering Inspection");
                CmbInspection.Items.Add("Harvest Inspection");
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0)
            {
                CmbInspection.Items.Add("Pre Flowering Inspection");
                CmbInspection.Items.Add("Flowering Inspection");
                CmbInspection.Items.Add("Post Flowering Inspection");
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0)
            {
                CmbInspection.Items.Add("Pre Flowering Inspection");
                CmbInspection.Items.Add("Flowering Inspection");
            }
            else if (pre_flowering.Rows.Count > 0)
            {
                CmbInspection.Items.Add("Pre Flowering Inspection");
            }
            return (pre_flowering.Rows.Count + flowering.Rows.Count + post_flowering.Rows.Count + harvest.Rows.Count);
        }


        private void Populate()
        {
            var x = DB.GetInstance().Query("SELECT * FROM sowing_report WHERE status = 'Pending'");
            if (x.Rows.Count > 0)
            {
                FlwSowingThumbnails.Controls.Clear();
                var listSowing = new ListSowingReport[x.Rows.Count];
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    string name = string.Empty;
                    string crop = string.Empty;

                    var z = new[] { "customer_id", "=", x.Rows[i]["customer_id"].ToString() };
                    DB.GetInstance().Get("customer", z);
                    name = DB.GetInstance().dt.Rows[0]["Firstname"].ToString() +" "+ DB.GetInstance().dt.Rows[0]["Lastname"].ToString();

                    z = new[] { "crop_id", "=", x.Rows[i]["crop_id"].ToString() };
                    DB.GetInstance().Get("crop", z);
                    crop = DB.GetInstance().dt.Rows[0]["crop_name"].ToString();

                    listSowing[i] = new ListSowingReport();
                    listSowing[i].Sowing_Id = x.Rows[i]["sowing_id"].ToString();                  
                    listSowing[i].ClientName = name;
                    listSowing[i].Crop = crop;
                    listSowing[i]._Date = x.Rows[i]["date_of_sowing"].ToString().Split(' ')[0];
                    listSowing[i]._Status = "new".ToUpper();

                    listSowing[i].Width = (FlwSowingThumbnails.Width - 25);
                    FlwSowingThumbnails.Controls.Add(listSowing[i]);
                    listSowing[i].DoubleClick += new System.EventHandler(this.Sowing_Report_DoubleClick);
                }
            }
        }

        private void PreFlowering(string sowing_id)
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("pre_flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_pre_flowing_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                var a = DB.GetInstance().GetCompoundCondition(Query, z);

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                var b = DB.GetInstance().GetCompoundCondition(Query, z);

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Pre Flowering Inspection";
                page.SiteLocation = "N/A";
                page.Isolation_Distance = Convert.ToDouble(x.Rows[0]["isolation_distance"].ToString());
                page.Seed_Source = x.Rows[0]["source"].ToString();
                page.Acreage = x.Rows[0]["acreage"].ToString();
                page.Uniform = x.Rows[0]["uniformity"].ToString();
                page.Proper_Rouging = x.Rows[0]["rouging"].ToString();
                page.OffType = x.Rows[0]["off_type"].ToString();
                page.RemovalOffType = x.Rows[0]["removal"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
                page.Width = (this.FlwInspections.Width - 25);
                this.FlwInspections.Controls.Add(page);
            }           
        }

        private void Flowering(string sowing_id)
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_flowing_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                var a = DB.GetInstance().GetCompoundCondition(Query, z);

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                var b = DB.GetInstance().GetCompoundCondition(Query, z);

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Flowering Inspection";
                page.Isolation_Distance_Maintained = x.Rows[0]["isolation_maintain"].ToString();
                page.Removal_Offtype_Proper_Rouging = x.Rows[0]["off_type_removal"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
                page.Width = (this.FlwInspections.Width - 25);
                this.FlwInspections.Controls.Add(page);
            }
        }

        private void PostFlowering(string sowing_id)
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("post_flowering_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_post_flowering_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                var a = DB.GetInstance().GetCompoundCondition(Query, z);

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                var b = DB.GetInstance().GetCompoundCondition(Query, z);

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Post Flowering Inspection";
                page.ConfirmationIssuesTakenCare = x.Rows[0]["issues_taken_care"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
                page.Width = (this.FlwInspections.Width - 25);
                this.FlwInspections.Controls.Add(page);
            }
        }

        private void Harvest(string sowing_id)
        {
            var z = new[] { "sowing_id", "=", sowing_id };
            var y = DB.GetInstance().Get("harvest_inspection", z);
            var x = DB.GetInstance().dt;
            var page = new Inspection_harvest_stage();
            if ((bool)(x.Rows.Count > 0))
            {
                string Query = "SELECT u.firstname, u.last_name FROM user u, user_account a WHERE u.employee_id = a.employee_id AND a.user_id = @a";
                z = new[] { x.Rows[0][1].ToString() };
                var a = DB.GetInstance().GetCompoundCondition(Query, z);

                Query = "SELECT c.certification_no FROM certification_number c, sowing_report s WHERE c.certification_id = s.certification_id AND s.sowing_id = @b";
                z = new[] { x.Rows[0][1].ToString() };
                var b = DB.GetInstance().GetCompoundCondition(Query, z);

                page.Certification_No = (b.Rows.Count > 0) ? b.Rows[0][0].ToString() : "N/A";
                page.Inspector = a.Rows[0][0].ToString() + " " + a.Rows[0][1].ToString();
                page.Date = Convert.ToDateTime(x.Rows[0]["date"].ToString());
                page.Description = "Harvest Inspection";
                page.Maturity = x.Rows[0]["maturity"].ToString();
                page.Remarks = x.Rows[0]["remarks"].ToString();
                page.Width = (this.FlwInspections.Width - 25);
                this.FlwInspections.Controls.Add(page);
            }
        }


        public void PopulateInspections(UserControl control)
        {           
        }

 
        public static void InvokeOpenForm(Form form)
        {            
            sowing.OpenForm(form);
        }

        public void OpenForm(Form form)
        {
            Bitmap bitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                Color dark = Color.FromArgb((int)(255 * 0.60), Color.Black);
                using (Brush brush = new SolidBrush(dark))
                {
                    graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }

            using (Panel pnl = new Panel())
            {
                pnl.Location = new Point(0, 0);
                pnl.Size = this.ClientRectangle.Size;
                pnl.BackgroundImage = bitmap;
                this.Controls.Add(pnl);
                pnl.BringToFront();

                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }
        private void Sowing_Report_DoubleClick(object sender, EventArgs e)
        {
            PnlActionControls.Controls.Clear();
            FlwInspections.Controls.Clear();
            var x = (ListSowingReport)sender;
            sowing_idx = x.Sowing_Id;
            var z = new[] { "sowing_id", "=", x.Sowing_Id };
            CmbInspection.Visible = false;
            sowing_report_page("sowing_report", z, x.Sowing_Id);

        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void CmbInspection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CmbInspection.SelectedIndex == 0)
            {
                FlwInspections.Controls.Clear();
                PreFlowering(sowing_idx);
            }
            else if (CmbInspection.SelectedIndex == 1)
            {
                FlwInspections.Controls.Clear();
                Flowering(sowing_idx);
            }
            else if (CmbInspection.SelectedIndex == 2)
            {
                FlwInspections.Controls.Clear();
                PostFlowering(sowing_idx);
            }
            else if (CmbInspection.SelectedIndex == 3)
            {
                FlwInspections.Controls.Clear();
                Harvest(sowing_idx);
            }
        }

        private void BtnAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWindowSize_Click(object sender, EventArgs e)
        {
            ButtonClickChecker = ButtonClickCount % 2;
            if (ButtonClickChecker == 0)
            {
                BtnWindowSize.Iconimage = WindowSizeImageList.Images[1];
                this.WindowState = FormWindowState.Maximized;
            }
            else if (ButtonClickChecker > 0)
            {
                BtnWindowSize.Iconimage = WindowSizeImageList.Images[0];
                this.WindowState = FormWindowState.Normal;
            }
            ButtonClickCount++;
        }
    }
}
