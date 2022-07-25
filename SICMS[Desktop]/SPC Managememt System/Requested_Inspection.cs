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
    public partial class Requested_Inspection : Form
    {
        private string request_id;
        private string deposit_path;
        public Requested_Inspection()
        {
            InitializeComponent();
        }


        private void Requested_Inspection_Load(object sender, EventArgs e)
        {
            PopulatePending();
            PopulateAccepted();
        }

        private void Request_Accepted_Click(object sender, EventArgs e)
        {
            Request_Accepted x = (Request_Accepted)sender;
            DisplayData(x.Request_Id);
            if (!PnlRequest.Visible)
                PnlRequest.Visible = true;
        }

        private void Request_Pending_Click(object sender, EventArgs e)
        {
            Request_Pending x = (Request_Pending)sender;
            DisplayData(x.Request_Id);
            if (!PnlRequest.Visible)
                PnlRequest.Visible = true;
        }

        private void LinkLblViewDepositSlip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(bool)(LinkLblViewDepositSlip.Text == "N/A"))
            {
                var x = new ImagePreview(deposit_path);
                x.ShowDialog();
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            var x = new SetAppointment(request_id);
            x.FormClosed += Approve_FormClosed;
            OpenForm(x);
        }

        private void Approve_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateAccepted();
            PnlRequest.Visible = false;
        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            var x = new DeclineRequest(request_id);
            x.FormClosed += Decline_FormClosed;
            OpenForm(x);
        }

        private void BtnAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Decline_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulatePending();
            PnlRequest.Visible = false;
        }



        private void PopulatePending()
        {
            var w = new[] { "status","=","pending" };
            DB.GetInstance().Get("requested_inspection", w);
            var x = DB.GetInstance().dt;
            flowLayoutPending.Controls.Clear();
            if (x.Rows.Count > 0)
            {
                var list = new Request_Pending[x.Rows.Count];
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    string name = string.Empty;
                    string crop = string.Empty;

                    string Query = "SELECT c.customer_id, c.Firstname, c.Lastname FROM sowing_report s, customer c WHERE s.customer_id = c.customer_id AND s.sowing_id = @a";
                    var z = new[] { x.Rows[i]["sowing_id"].ToString() };
                    var customer_details = DB.GetInstance().GetCompoundCondition(Query, z);

                    Query = "SELECT c.crop_name FROM sowing_report s, crop c WHERE s.crop_id = c.crop_id AND s.sowing_id = @a";
                    z = new[] { x.Rows[i]["sowing_id"].ToString() };
                    var crop_details = DB.GetInstance().GetCompoundCondition(Query, z);

                    name = customer_details.Rows[0][1].ToString() +" "+ customer_details.Rows[0][2].ToString();
                    crop = crop_details.Rows[0][0].ToString();

                    list[i] = new Request_Pending();
                    list[i].Request_Id = x.Rows[i]["request_id"].ToString();
                    list[i].Sowing_Id = x.Rows[i]["sowing_id"].ToString();
                    list[i].ClientName = name;
                    list[i].Crop = crop;
                    list[i]._Date = x.Rows[i]["date"].ToString().Split(' ')[0];
                    list[i].Inspectiontype = x.Rows[i]["inspection_type"].ToString();
                    list[i].Cursor = Cursors.Hand;
                    list[i].Width = (flowLayoutPending.Width - 25);
                    flowLayoutPending.Controls.Add(list[i]);
                    list[i].DoubleClick += new System.EventHandler(this.Request_Pending_Click);
                }
            }
        }

        private void PopulateAccepted()
        {
            var x = DB.GetInstance().Query("SELECT * FROM requested_inspection WHERE status = 'accepted'");
            flowLayoutAccepted.Controls.Clear();
            if (x.Rows.Count > 0)
            {
                var list = new Request_Accepted[x.Rows.Count];
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    string name = string.Empty;
                    string crop = string.Empty;

                    string Query = "SELECT c.customer_id, c.Firstname, c.Lastname FROM sowing_report s, customer c WHERE s.customer_id = c.customer_id AND s.sowing_id = @a";
                    var z = new[] { x.Rows[i]["sowing_id"].ToString() };
                    var customer_details = DB.GetInstance().GetCompoundCondition(Query, z);

                    Query = "SELECT c.crop_name FROM sowing_report s, crop c WHERE s.crop_id = c.crop_id AND s.sowing_id = @a";
                    z = new[] { x.Rows[i]["sowing_id"].ToString() };
                    var crop_details = DB.GetInstance().GetCompoundCondition(Query, z);

                    name = customer_details.Rows[0][1].ToString() + " " + customer_details.Rows[0][2].ToString();
                    crop = crop_details.Rows[0][0].ToString();

                    list[i] = new Request_Accepted();
                    list[i].Request_Id = x.Rows[i]["request_id"].ToString();
                    list[i].Sowing_Id = x.Rows[i]["sowing_id"].ToString();
                    list[i].ClientName = name;
                    list[i].Crop = crop;
                    list[i]._Date = x.Rows[i]["date"].ToString().Split(' ')[0];
                    list[i].Inspectiontype = x.Rows[i]["inspection_type"].ToString();
                    list[i].Cursor = Cursors.Hand;

                    list[i].Width = (flowLayoutAccepted.Width - 25);
                    flowLayoutAccepted.Controls.Add(list[i]);
                    list[i].DoubleClick += new System.EventHandler(this.Request_Accepted_Click);
                }
            }
        }

        private void DisplayData(string request_id)
        {
            var z = new[] { "request_id", "=", request_id };
            DB.GetInstance().Get("requested_inspection", z);
            var x = DB.GetInstance().dt;
            if (x.Rows.Count > 0)
            {
                this.request_id = request_id;
                string name = string.Empty;
                string description = string.Empty;
                string certification = string.Empty;
                string bankAck = string.Empty;
                string banknameAcc = string.Empty;
                string mobileAcknowledgement = string.Empty;
                string transacationId = string.Empty;
                string mobileservicename = string.Empty;
                string bankDepositpath = string.Empty;

                var b = new[] { "payment_id", "=", x.Rows[0]["payment_id"].ToString() };
                DB.GetInstance().Get("payment_details", b);
                if (DB.GetInstance().dt.Rows.Count > 0)
                {
                    var c = DB.GetInstance().dt;
                    bankAck = (c.Rows[0]["bank_id"].ToString() != "") ? "Yes" : "No";
                    bankDepositpath = (c.Rows[0]["bank_deposit_slip"].ToString() != "") ? Config.ImgPath + c.Rows[0]["bank_deposit_slip"].ToString() : "";
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
                        mobileservicename = DB.GetInstance().dt.Rows[0]["service_name"].ToString() + ": " + DB.GetInstance().dt.Rows[0]["contact"].ToString();
                        transacationId = c.Rows[0]["transaction_id"].ToString();
                    }
                }

                string Query = "SELECT c.customer_id, c.Firstname, c.Lastname FROM sowing_report s, customer c WHERE s.customer_id = c.customer_id AND s.sowing_id = @a";
                z = new[] { x.Rows[0]["sowing_id"].ToString() };
                var customer_details = DB.GetInstance().GetCompoundCondition(Query, z);

                Query = "SELECT c.certification_no FROM sowing_report s, certification_number c WHERE s.certification_id = c.certification_id AND s.sowing_id = @a";
                z = new[] { x.Rows[0]["sowing_id"].ToString() };
                var certification_details = DB.GetInstance().GetCompoundCondition(Query, z);

                name = customer_details.Rows[0][1].ToString() + " " + customer_details.Rows[0][2].ToString();
                certification = (certification_details.Rows.Count > 0) ? certification_details.Rows[0][0].ToString() : "N/A";
                description = (x.Rows[0]["inspection_type"].ToString() != "") ? x.Rows[0]["inspection_type"].ToString() : "N/A";
                deposit_path = (bankDepositpath != "") ? bankDepositpath : "";

                Lblname.Text = name;
                LblCertificationNo.Text = certification;
                LblInspectionType.Text = description;
                LblAcknowledgeBankUsed.Text = bankAck;
                LblBankName.Text = banknameAcc;
                LblAcknowledgeMobileUsed.Text = mobileAcknowledgement;
                LblMobileService.Text = mobileservicename;
                LblTransactionId.Text = transacationId;
                LinkLblViewDepositSlip.Text = (deposit_path != "") ? "View Deposit Slip" : "N/A";
                BtnDecline.Enabled = true;
                BtnApprove.Enabled = true;
            }
            else
            {
                BtnDecline.Enabled = false;
                BtnApprove.Enabled = false;
            }
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


    }
}
