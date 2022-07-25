using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class _Home : Form
    {
        int mov, movX, movY;
        int ButtonClickCount = 0;
        int ButtonClickChecker = 0;
        public _Home()
        {
            InitializeComponent();
            BtnWindowSize.Iconimage = WindowSizeImageList.Images[0];
            BtnAppExit.Iconimage = WindowSizeImageList.Images[2];
            BtnMinimize.Iconimage = WindowSizeImageList.Images[3];
        }

        private void BtnCLients_Click(object sender, EventArgs e)
        {
            NavigateButtons_Main(BtnCLients.Name);
        }

        private void BtnSeeds_Click(object sender, EventArgs e)
        {
            NavigateButtons_Main(BtnSeeds.Name);
        }


        private void BtnStandards_Click(object sender, EventArgs e)
        {
            NavigateButtons_Main(BtnStandards.Name);
        }

        private void BtnRequestedInspection_Click(object sender, EventArgs e)
        {
            var x = new Requested_Inspection();
            x.ShowDialog();
        }

        private void BtnSowingReport_Click(object sender, EventArgs e)
        {
            var x = new Sowing_Report();
            x.ShowDialog();
        }
        private void BtnAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void BtnCertification_Click(object sender, EventArgs e)
        {

        }
        /*
         * Title: House Keeping Methods 
         * Role: To drag the flat form
         */
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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

        private void BtnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate () {
                    string h = DateTime.Now.ToString("HH");
                    string m = DateTime.Now.ToString("mm");
                    string s = DateTime.Now.ToString("ss");
                    LblTime.Text = string.Format("{0}:{1}:{2}", h, m, s);
                    string[] dayTime = new string[3] { "Good Morning", "Good Afternoon", "Good Evening" };
        
                    int AmPm = Int32.Parse(h);
                    if (AmPm <= 11)
                    {
                        LblPmAm.Text = "am";
                        LblGreetings.Text = string.Format("{0}", dayTime[0]);
                    }
                    else if (AmPm <= 17)
                    {
                        LblPmAm.Text = "pm";
                        LblGreetings.Text = string.Format("{0}", dayTime[1]);
                    }
                    else
                    {
                        LblPmAm.Text = "pm";
                        LblGreetings.Text = string.Format("{0}", dayTime[2]);
                    }

                });
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void NotifyNoSowingReport_Click(object sender, EventArgs e)
        {
            BtnSowingReport_Click(sender, e);
        }

        private void NotifyNoInspectionRequests_Click(object sender, EventArgs e)
        {
            BtnRequestedInspection_Click(sender, e);
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void LinkPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = new Payment();
            OpenForm(x);
        }

        private void LinkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = new Settings();
            OpenForm(x);
        }

        private void LinkInspectors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = new SIOs();
            OpenForm(x);
        }

        private void LinkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void NavigateButtons_Main(string name)
        {
            switch (name)
            {
                case "BtnCLients":
                    BtnCLients.color = Color.FromArgb(148, 182, 55);
                    BtnSeeds.color = Color.FromArgb(93, 85, 82);
                    BtnStandards.color = Color.FromArgb(93, 85, 82);
                    standard_Interface1.Visible = false;
                    clients_Interface1.Visible = true;
                    seeds_Interface1.Visible = false;
                    break;
                case "BtnSeeds":
                    BtnCLients.color = Color.FromArgb(93, 85, 82);
                    BtnSeeds.color = Color.FromArgb(148, 182, 55);
                    BtnStandards.color = Color.FromArgb(93, 85, 82);
                    standard_Interface1.Visible = false;
                    clients_Interface1.Visible = false;
                    seeds_Interface1.Visible = true;
                    break;
                default:
                    BtnCLients.color = Color.FromArgb(93, 85, 82);
                    BtnSeeds.color = Color.FromArgb(93, 85, 82);
                    BtnStandards.color = Color.FromArgb(148, 182, 55);
                    standard_Interface1.Visible = true;
                    clients_Interface1.Visible = false;
                    seeds_Interface1.Visible = false;
                    break;
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
