namespace SPC_Managememt_System
{
    partial class _Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Home));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LinkProfile = new Ambiance.Ambiance_LinkLabel();
            this.LinkLogOut = new Ambiance.Ambiance_LinkLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LinkSettings = new Ambiance.Ambiance_LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblPmAm = new iTalk_HeaderLabel();
            this.LinkPayment = new Ambiance.Ambiance_LinkLabel();
            this.LblTime = new iTalk_HeaderLabel();
            this.LinkInspectors = new Ambiance.Ambiance_LinkLabel();
            this.LblGreetings = new iTalk_HeaderLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnStandards = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnSeeds = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnCLients = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnRequestedInspection = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSowingReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAppExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnWindowSize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.WindowSizeImageList = new System.Windows.Forms.ImageList(this.components);
            this.TimerWatch = new System.Windows.Forms.Timer(this.components);
            this.clients_Interface1 = new SPC_Managememt_System.Clients_Interface();
            this.standard_Interface1 = new SPC_Managememt_System.Standard_Interface();
            this.seeds_Interface1 = new SPC_Managememt_System.Seeds_Interface();
            this.iTalk_HeaderLabel1 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel2 = new iTalk_HeaderLabel();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 0;
            this.Elipse.TargetControl = this;
            // 
            // PnlHeader
            // 
            this.PnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.PnlHeader.Controls.Add(this.pictureBox1);
            this.PnlHeader.Controls.Add(this.LinkProfile);
            this.PnlHeader.Controls.Add(this.LinkLogOut);
            this.PnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.PnlHeader.Location = new System.Drawing.Point(-1, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1200, 29);
            this.PnlHeader.TabIndex = 3;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LinkProfile
            // 
            this.LinkProfile.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.LinkProfile.AutoSize = true;
            this.LinkProfile.BackColor = System.Drawing.Color.Transparent;
            this.LinkProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LinkProfile.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkProfile.LinkColor = System.Drawing.Color.White;
            this.LinkProfile.Location = new System.Drawing.Point(298, 1);
            this.LinkProfile.Name = "LinkProfile";
            this.LinkProfile.Size = new System.Drawing.Size(110, 20);
            this.LinkProfile.TabIndex = 15;
            this.LinkProfile.TabStop = true;
            this.LinkProfile.Text = "Jairos Nyirenda";
            this.LinkProfile.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProfile_LinkClicked);
            // 
            // LinkLogOut
            // 
            this.LinkLogOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.LinkLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLogOut.AutoSize = true;
            this.LinkLogOut.BackColor = System.Drawing.Color.Transparent;
            this.LinkLogOut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LinkLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkLogOut.LinkColor = System.Drawing.Color.White;
            this.LinkLogOut.Location = new System.Drawing.Point(995, 1);
            this.LinkLogOut.Name = "LinkLogOut";
            this.LinkLogOut.Size = new System.Drawing.Size(60, 20);
            this.LinkLogOut.TabIndex = 15;
            this.LinkLogOut.TabStop = true;
            this.LinkLogOut.Text = "Log out";
            this.LinkLogOut.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogOut_LinkClicked);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 23);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "SICMS";
            // 
            // LinkSettings
            // 
            this.LinkSettings.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.LinkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkSettings.AutoSize = true;
            this.LinkSettings.BackColor = System.Drawing.Color.Transparent;
            this.LinkSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LinkSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkSettings.LinkColor = System.Drawing.Color.White;
            this.LinkSettings.Location = new System.Drawing.Point(537, 12);
            this.LinkSettings.Name = "LinkSettings";
            this.LinkSettings.Size = new System.Drawing.Size(62, 20);
            this.LinkSettings.TabIndex = 17;
            this.LinkSettings.TabStop = true;
            this.LinkSettings.Text = "Settings";
            this.LinkSettings.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSettings_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(72)))), ((int)(((byte)(42)))));
            this.panel2.Location = new System.Drawing.Point(-2, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 4);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.LblPmAm);
            this.panel3.Controls.Add(this.LinkPayment);
            this.panel3.Controls.Add(this.LinkSettings);
            this.panel3.Controls.Add(this.LblTime);
            this.panel3.Controls.Add(this.LinkInspectors);
            this.panel3.Controls.Add(this.LblGreetings);
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 39);
            this.panel3.TabIndex = 5;
            // 
            // LblPmAm
            // 
            this.LblPmAm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPmAm.AutoSize = true;
            this.LblPmAm.BackColor = System.Drawing.Color.Transparent;
            this.LblPmAm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPmAm.ForeColor = System.Drawing.Color.White;
            this.LblPmAm.Location = new System.Drawing.Point(1117, 11);
            this.LblPmAm.Name = "LblPmAm";
            this.LblPmAm.Size = new System.Drawing.Size(40, 25);
            this.LblPmAm.TabIndex = 10;
            this.LblPmAm.Text = "pm";
            // 
            // LinkPayment
            // 
            this.LinkPayment.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.LinkPayment.AutoSize = true;
            this.LinkPayment.BackColor = System.Drawing.Color.Transparent;
            this.LinkPayment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LinkPayment.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkPayment.LinkColor = System.Drawing.Color.White;
            this.LinkPayment.Location = new System.Drawing.Point(394, 12);
            this.LinkPayment.Name = "LinkPayment";
            this.LinkPayment.Size = new System.Drawing.Size(127, 20);
            this.LinkPayment.TabIndex = 14;
            this.LinkPayment.TabStop = true;
            this.LinkPayment.Text = "Payment Methods";
            this.LinkPayment.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkPayment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPayment_LinkClicked);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.White;
            this.LblTime.Location = new System.Drawing.Point(1023, 11);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(100, 25);
            this.LblTime.TabIndex = 9;
            this.LblTime.Text = "HH:mm:ss";
            // 
            // LinkInspectors
            // 
            this.LinkInspectors.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.LinkInspectors.AutoSize = true;
            this.LinkInspectors.BackColor = System.Drawing.Color.Transparent;
            this.LinkInspectors.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LinkInspectors.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkInspectors.LinkColor = System.Drawing.Color.White;
            this.LinkInspectors.Location = new System.Drawing.Point(297, 12);
            this.LinkInspectors.Name = "LinkInspectors";
            this.LinkInspectors.Size = new System.Drawing.Size(76, 20);
            this.LinkInspectors.TabIndex = 13;
            this.LinkInspectors.TabStop = true;
            this.LinkInspectors.Text = "Inspectors";
            this.LinkInspectors.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkInspectors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInspectors_LinkClicked);
            // 
            // LblGreetings
            // 
            this.LblGreetings.AutoSize = true;
            this.LblGreetings.BackColor = System.Drawing.Color.Transparent;
            this.LblGreetings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreetings.ForeColor = System.Drawing.Color.White;
            this.LblGreetings.Location = new System.Drawing.Point(11, 8);
            this.LblGreetings.Name = "LblGreetings";
            this.LblGreetings.Size = new System.Drawing.Size(137, 25);
            this.LblGreetings.TabIndex = 11;
            this.LblGreetings.Text = "Good Morning";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.BtnStandards);
            this.panel5.Controls.Add(this.BtnSeeds);
            this.panel5.Controls.Add(this.BtnCLients);
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(98, 482);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(101, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 100);
            this.panel6.TabIndex = 8;
            // 
            // BtnStandards
            // 
            this.BtnStandards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnStandards.color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnStandards.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnStandards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnStandards.ForeColor = System.Drawing.Color.White;
            this.BtnStandards.Image = ((System.Drawing.Image)(resources.GetObject("BtnStandards.Image")));
            this.BtnStandards.ImagePosition = 7;
            this.BtnStandards.ImageZoom = 50;
            this.BtnStandards.LabelPosition = 20;
            this.BtnStandards.LabelText = "Standards";
            this.BtnStandards.Location = new System.Drawing.Point(3, 177);
            this.BtnStandards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStandards.Name = "BtnStandards";
            this.BtnStandards.Size = new System.Drawing.Size(91, 81);
            this.BtnStandards.TabIndex = 11;
            this.BtnStandards.Click += new System.EventHandler(this.BtnStandards_Click);
            // 
            // BtnSeeds
            // 
            this.BtnSeeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnSeeds.color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnSeeds.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnSeeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnSeeds.ForeColor = System.Drawing.Color.White;
            this.BtnSeeds.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeeds.Image")));
            this.BtnSeeds.ImagePosition = 7;
            this.BtnSeeds.ImageZoom = 50;
            this.BtnSeeds.LabelPosition = 20;
            this.BtnSeeds.LabelText = "Seeds";
            this.BtnSeeds.Location = new System.Drawing.Point(3, 94);
            this.BtnSeeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSeeds.Name = "BtnSeeds";
            this.BtnSeeds.Size = new System.Drawing.Size(91, 81);
            this.BtnSeeds.TabIndex = 9;
            this.BtnSeeds.Click += new System.EventHandler(this.BtnSeeds_Click);
            // 
            // BtnCLients
            // 
            this.BtnCLients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnCLients.color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.BtnCLients.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnCLients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCLients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnCLients.ForeColor = System.Drawing.Color.White;
            this.BtnCLients.Image = ((System.Drawing.Image)(resources.GetObject("BtnCLients.Image")));
            this.BtnCLients.ImagePosition = 7;
            this.BtnCLients.ImageZoom = 50;
            this.BtnCLients.LabelPosition = 20;
            this.BtnCLients.LabelText = "Clients";
            this.BtnCLients.Location = new System.Drawing.Point(3, 6);
            this.BtnCLients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCLients.Name = "BtnCLients";
            this.BtnCLients.Size = new System.Drawing.Size(91, 86);
            this.BtnCLients.TabIndex = 8;
            this.BtnCLients.Click += new System.EventHandler(this.BtnCLients_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(174)))), ((int)(((byte)(167)))));
            this.panel7.Controls.Add(this.BtnRequestedInspection);
            this.panel7.Controls.Add(this.BtnSowingReport);
            this.panel7.Location = new System.Drawing.Point(98, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 497);
            this.panel7.TabIndex = 8;
            // 
            // BtnRequestedInspection
            // 
            this.BtnRequestedInspection.Active = false;
            this.BtnRequestedInspection.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(164)))), ((int)(((byte)(156)))));
            this.BtnRequestedInspection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRequestedInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(142)))), ((int)(((byte)(133)))));
            this.BtnRequestedInspection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRequestedInspection.BorderRadius = 0;
            this.BtnRequestedInspection.ButtonText = "Inspection Requests";
            this.BtnRequestedInspection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRequestedInspection.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRequestedInspection.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRequestedInspection.Iconimage = null;
            this.BtnRequestedInspection.Iconimage_right = null;
            this.BtnRequestedInspection.Iconimage_right_Selected = null;
            this.BtnRequestedInspection.Iconimage_Selected = null;
            this.BtnRequestedInspection.IconMarginLeft = 0;
            this.BtnRequestedInspection.IconMarginRight = 0;
            this.BtnRequestedInspection.IconRightVisible = true;
            this.BtnRequestedInspection.IconRightZoom = 0D;
            this.BtnRequestedInspection.IconVisible = true;
            this.BtnRequestedInspection.IconZoom = 90D;
            this.BtnRequestedInspection.IsTab = false;
            this.BtnRequestedInspection.Location = new System.Drawing.Point(3, 50);
            this.BtnRequestedInspection.Name = "BtnRequestedInspection";
            this.BtnRequestedInspection.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(142)))), ((int)(((byte)(133)))));
            this.BtnRequestedInspection.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(164)))), ((int)(((byte)(156)))));
            this.BtnRequestedInspection.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRequestedInspection.selected = false;
            this.BtnRequestedInspection.Size = new System.Drawing.Size(184, 35);
            this.BtnRequestedInspection.TabIndex = 12;
            this.BtnRequestedInspection.Text = "Inspection Requests";
            this.BtnRequestedInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRequestedInspection.Textcolor = System.Drawing.Color.White;
            this.BtnRequestedInspection.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequestedInspection.Click += new System.EventHandler(this.BtnRequestedInspection_Click);
            // 
            // BtnSowingReport
            // 
            this.BtnSowingReport.Active = false;
            this.BtnSowingReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(164)))), ((int)(((byte)(156)))));
            this.BtnSowingReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSowingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(142)))), ((int)(((byte)(133)))));
            this.BtnSowingReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSowingReport.BorderRadius = 0;
            this.BtnSowingReport.ButtonText = "Sowing Reports";
            this.BtnSowingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSowingReport.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSowingReport.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSowingReport.Iconimage = null;
            this.BtnSowingReport.Iconimage_right = null;
            this.BtnSowingReport.Iconimage_right_Selected = null;
            this.BtnSowingReport.Iconimage_Selected = null;
            this.BtnSowingReport.IconMarginLeft = 0;
            this.BtnSowingReport.IconMarginRight = 0;
            this.BtnSowingReport.IconRightVisible = true;
            this.BtnSowingReport.IconRightZoom = 0D;
            this.BtnSowingReport.IconVisible = true;
            this.BtnSowingReport.IconZoom = 90D;
            this.BtnSowingReport.IsTab = false;
            this.BtnSowingReport.Location = new System.Drawing.Point(3, 9);
            this.BtnSowingReport.Name = "BtnSowingReport";
            this.BtnSowingReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(142)))), ((int)(((byte)(133)))));
            this.BtnSowingReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(164)))), ((int)(((byte)(156)))));
            this.BtnSowingReport.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSowingReport.selected = false;
            this.BtnSowingReport.Size = new System.Drawing.Size(184, 35);
            this.BtnSowingReport.TabIndex = 9;
            this.BtnSowingReport.Text = "Sowing Reports";
            this.BtnSowingReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSowingReport.Textcolor = System.Drawing.Color.White;
            this.BtnSowingReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSowingReport.Click += new System.EventHandler(this.BtnSowingReport_Click);
            // 
            // BtnAppExit
            // 
            this.BtnAppExit.Active = false;
            this.BtnAppExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnAppExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnAppExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAppExit.BorderRadius = 0;
            this.BtnAppExit.ButtonText = "";
            this.BtnAppExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAppExit.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAppExit.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAppExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAppExit.Iconimage")));
            this.BtnAppExit.Iconimage_right = null;
            this.BtnAppExit.Iconimage_right_Selected = null;
            this.BtnAppExit.Iconimage_Selected = null;
            this.BtnAppExit.IconMarginLeft = 0;
            this.BtnAppExit.IconMarginRight = 0;
            this.BtnAppExit.IconRightVisible = true;
            this.BtnAppExit.IconRightZoom = 0D;
            this.BtnAppExit.IconVisible = true;
            this.BtnAppExit.IconZoom = 60D;
            this.BtnAppExit.IsTab = false;
            this.BtnAppExit.Location = new System.Drawing.Point(1153, 0);
            this.BtnAppExit.Name = "BtnAppExit";
            this.BtnAppExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnAppExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnAppExit.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAppExit.selected = false;
            this.BtnAppExit.Size = new System.Drawing.Size(35, 35);
            this.BtnAppExit.TabIndex = 0;
            this.BtnAppExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppExit.Textcolor = System.Drawing.Color.White;
            this.BtnAppExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppExit.Click += new System.EventHandler(this.BtnAppExit_Click);
            // 
            // BtnWindowSize
            // 
            this.BtnWindowSize.Active = false;
            this.BtnWindowSize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnWindowSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnWindowSize.BorderRadius = 0;
            this.BtnWindowSize.ButtonText = "";
            this.BtnWindowSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWindowSize.DisabledColor = System.Drawing.Color.Gray;
            this.BtnWindowSize.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnWindowSize.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnWindowSize.Iconimage")));
            this.BtnWindowSize.Iconimage_right = null;
            this.BtnWindowSize.Iconimage_right_Selected = null;
            this.BtnWindowSize.Iconimage_Selected = null;
            this.BtnWindowSize.IconMarginLeft = 0;
            this.BtnWindowSize.IconMarginRight = 0;
            this.BtnWindowSize.IconRightVisible = true;
            this.BtnWindowSize.IconRightZoom = 0D;
            this.BtnWindowSize.IconVisible = true;
            this.BtnWindowSize.IconZoom = 60D;
            this.BtnWindowSize.IsTab = false;
            this.BtnWindowSize.Location = new System.Drawing.Point(1112, 0);
            this.BtnWindowSize.Name = "BtnWindowSize";
            this.BtnWindowSize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnWindowSize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnWindowSize.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnWindowSize.selected = false;
            this.BtnWindowSize.Size = new System.Drawing.Size(35, 35);
            this.BtnWindowSize.TabIndex = 2;
            this.BtnWindowSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWindowSize.Textcolor = System.Drawing.Color.White;
            this.BtnWindowSize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWindowSize.Click += new System.EventHandler(this.BtnWindowSize_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Active = false;
            this.BtnMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinimize.BorderRadius = 0;
            this.BtnMinimize.ButtonText = "";
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Iconimage")));
            this.BtnMinimize.Iconimage_right = null;
            this.BtnMinimize.Iconimage_right_Selected = null;
            this.BtnMinimize.Iconimage_Selected = null;
            this.BtnMinimize.IconMarginLeft = 0;
            this.BtnMinimize.IconMarginRight = 0;
            this.BtnMinimize.IconRightVisible = true;
            this.BtnMinimize.IconRightZoom = 0D;
            this.BtnMinimize.IconVisible = true;
            this.BtnMinimize.IconZoom = 60D;
            this.BtnMinimize.IsTab = false;
            this.BtnMinimize.Location = new System.Drawing.Point(1071, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(182)))), ((int)(((byte)(55)))));
            this.BtnMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnMinimize.selected = false;
            this.BtnMinimize.Size = new System.Drawing.Size(35, 35);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimize.Textcolor = System.Drawing.Color.White;
            this.BtnMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // WindowSizeImageList
            // 
            this.WindowSizeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("WindowSizeImageList.ImageStream")));
            this.WindowSizeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.WindowSizeImageList.Images.SetKeyName(0, "icons8_maximize_window_50px.png");
            this.WindowSizeImageList.Images.SetKeyName(1, "icons8_restore_window_50px.png");
            this.WindowSizeImageList.Images.SetKeyName(2, "icons8_delete_sign_50px.png");
            this.WindowSizeImageList.Images.SetKeyName(3, "icons8_minimize_window_50px.png");
            // 
            // TimerWatch
            // 
            this.TimerWatch.Enabled = true;
            this.TimerWatch.Tick += new System.EventHandler(this.TimerWatch_Tick);
            // 
            // clients_Interface1
            // 
            this.clients_Interface1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clients_Interface1.Location = new System.Drawing.Point(291, 72);
            this.clients_Interface1.Name = "clients_Interface1";
            this.clients_Interface1.Size = new System.Drawing.Size(908, 480);
            this.clients_Interface1.TabIndex = 10;
            this.clients_Interface1.Visible = false;
            // 
            // standard_Interface1
            // 
            this.standard_Interface1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standard_Interface1.Location = new System.Drawing.Point(291, 70);
            this.standard_Interface1.Name = "standard_Interface1";
            this.standard_Interface1.Size = new System.Drawing.Size(908, 482);
            this.standard_Interface1.TabIndex = 9;
            this.standard_Interface1.Visible = false;
            // 
            // seeds_Interface1
            // 
            this.seeds_Interface1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seeds_Interface1.Location = new System.Drawing.Point(291, 72);
            this.seeds_Interface1.Name = "seeds_Interface1";
            this.seeds_Interface1.Size = new System.Drawing.Size(908, 480);
            this.seeds_Interface1.TabIndex = 11;
            this.seeds_Interface1.Visible = false;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(475, 247);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(561, 41);
            this.iTalk_HeaderLabel1.TabIndex = 15;
            this.iTalk_HeaderLabel1.Text = "Ooops! Nothing to Display Yet! :(";
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(476, 296);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(304, 32);
            this.iTalk_HeaderLabel2.TabIndex = 16;
            this.iTalk_HeaderLabel2.Text = "But how are today ? :)";
            // 
            // _Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.seeds_Interface1);
            this.Controls.Add(this.clients_Interface1);
            this.Controls.Add(this.standard_Interface1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnWindowSize);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnAppExit);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.iTalk_HeaderLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuTileButton BtnCLients;
        private Bunifu.Framework.UI.BunifuTileButton BtnStandards;
        private Bunifu.Framework.UI.BunifuTileButton BtnSeeds;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSowingReport;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRequestedInspection;
        private Bunifu.Framework.UI.BunifuFlatButton BtnWindowSize;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAppExit;
        private System.Windows.Forms.ImageList WindowSizeImageList;
        private System.Windows.Forms.Timer TimerWatch;
        private iTalk_HeaderLabel LblTime;
        private iTalk_HeaderLabel LblPmAm;
        private iTalk_HeaderLabel LblGreetings;
        private Ambiance.Ambiance_LinkLabel LinkInspectors;
        private Ambiance.Ambiance_LinkLabel LinkPayment;
        private Ambiance.Ambiance_LinkLabel LinkLogOut;
        private Ambiance.Ambiance_LinkLabel LinkSettings;
        private Ambiance.Ambiance_LinkLabel LinkProfile;
        private Standard_Interface standard_Interface1;
        private Clients_Interface clients_Interface1;
        private Seeds_Interface seeds_Interface1;
        private iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk_HeaderLabel iTalk_HeaderLabel2;
    }
}

