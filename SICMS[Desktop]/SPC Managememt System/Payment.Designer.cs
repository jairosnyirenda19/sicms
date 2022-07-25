namespace SPC_Managememt_System
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.BtnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ambiance_TabControl1 = new Ambiance.Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ambiance_HeaderLabel7 = new Ambiance.Ambiance_HeaderLabel();
            this.LblMsg = new Ambiance.Ambiance_HeaderLabel();
            this.CmbMode = new Ambiance.Ambiance_ComboBox();
            this.ambiance_HeaderLabel4 = new Ambiance.Ambiance_HeaderLabel();
            this.TxtNum = new Ambiance.Ambiance_TextBox();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel2 = new Ambiance.Ambiance_HeaderLabel();
            this.Txtname = new Ambiance.Ambiance_TextBox();
            this.ambiance_HeaderLabel25 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel34 = new Ambiance.Ambiance_HeaderLabel();
            this.BtnSave = new Ambiance.Ambiance_Button_1();
            this.BtnCancel = new Ambiance.Ambiance_Button_1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LblMsg_One = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel5 = new Ambiance.Ambiance_HeaderLabel();
            this.BtnAddMode = new Ambiance.Ambiance_Button_1();
            this.BtnCancelMode = new Ambiance.Ambiance_Button_1();
            this.ambiance_HeaderLabel3 = new Ambiance.Ambiance_HeaderLabel();
            this.TxtMode = new Ambiance.Ambiance_TextBox();
            this.LblPositon = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Active = false;
            this.BtnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.BorderRadius = 0;
            this.BtnClose.ButtonText = "";
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.DisabledColor = System.Drawing.Color.Gray;
            this.BtnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnClose.Iconimage")));
            this.BtnClose.Iconimage_right = null;
            this.BtnClose.Iconimage_right_Selected = null;
            this.BtnClose.Iconimage_Selected = null;
            this.BtnClose.IconMarginLeft = 0;
            this.BtnClose.IconMarginRight = 0;
            this.BtnClose.IconRightVisible = true;
            this.BtnClose.IconRightZoom = 0D;
            this.BtnClose.IconVisible = true;
            this.BtnClose.IconZoom = 60D;
            this.BtnClose.IsTab = false;
            this.BtnClose.Location = new System.Drawing.Point(655, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClose.selected = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 54;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Textcolor = System.Drawing.Color.White;
            this.BtnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ambiance_TabControl1
            // 
            this.ambiance_TabControl1.Controls.Add(this.tabPage1);
            this.ambiance_TabControl1.Controls.Add(this.tabPage2);
            this.ambiance_TabControl1.Controls.Add(this.tabPage3);
            this.ambiance_TabControl1.ItemSize = new System.Drawing.Size(80, 24);
            this.ambiance_TabControl1.Location = new System.Drawing.Point(3, 37);
            this.ambiance_TabControl1.Name = "ambiance_TabControl1";
            this.ambiance_TabControl1.SelectedIndex = 0;
            this.ambiance_TabControl1.Size = new System.Drawing.Size(686, 377);
            this.ambiance_TabControl1.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Payment Modes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 334);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel7);
            this.tabPage2.Controls.Add(this.LblMsg);
            this.tabPage2.Controls.Add(this.CmbMode);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel4);
            this.tabPage2.Controls.Add(this.TxtNum);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel1);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel2);
            this.tabPage2.Controls.Add(this.Txtname);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel25);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel34);
            this.tabPage2.Controls.Add(this.BtnSave);
            this.tabPage2.Controls.Add(this.BtnCancel);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment Mode";
            // 
            // ambiance_HeaderLabel7
            // 
            this.ambiance_HeaderLabel7.AutoSize = true;
            this.ambiance_HeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel7.Location = new System.Drawing.Point(565, 105);
            this.ambiance_HeaderLabel7.Name = "ambiance_HeaderLabel7";
            this.ambiance_HeaderLabel7.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel7.TabIndex = 134;
            this.ambiance_HeaderLabel7.Text = "*";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.BackColor = System.Drawing.Color.Transparent;
            this.LblMsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.LblMsg.Location = new System.Drawing.Point(201, 150);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(252, 19);
            this.LblMsg.TabIndex = 133;
            this.LblMsg.Text = "All mandatory (*) fields should filled";
            // 
            // CmbMode
            // 
            this.CmbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.CmbMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbMode.DropDownHeight = 100;
            this.CmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.CmbMode.FormattingEnabled = true;
            this.CmbMode.HoverSelectionColor = System.Drawing.Color.Empty;
            this.CmbMode.IntegralHeight = false;
            this.CmbMode.ItemHeight = 20;
            this.CmbMode.Location = new System.Drawing.Point(205, 26);
            this.CmbMode.Name = "CmbMode";
            this.CmbMode.Size = new System.Drawing.Size(349, 26);
            this.CmbMode.StartIndex = 0;
            this.CmbMode.TabIndex = 113;
            this.CmbMode.SelectedIndexChanged += new System.EventHandler(this.CmbMode_SelectedIndexChanged);
            // 
            // ambiance_HeaderLabel4
            // 
            this.ambiance_HeaderLabel4.AutoSize = true;
            this.ambiance_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel4.Location = new System.Drawing.Point(63, 113);
            this.ambiance_HeaderLabel4.Name = "ambiance_HeaderLabel4";
            this.ambiance_HeaderLabel4.Size = new System.Drawing.Size(119, 20);
            this.ambiance_HeaderLabel4.TabIndex = 112;
            this.ambiance_HeaderLabel4.Text = "Acc #/Mobile #:";
            // 
            // TxtNum
            // 
            this.TxtNum.BackColor = System.Drawing.Color.Transparent;
            this.TxtNum.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtNum.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNum.Location = new System.Drawing.Point(205, 109);
            this.TxtNum.MaxLength = 32767;
            this.TxtNum.Multiline = false;
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.ReadOnly = false;
            this.TxtNum.Size = new System.Drawing.Size(349, 28);
            this.TxtNum.TabIndex = 111;
            this.TxtNum.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNum.UseSystemPasswordChar = false;
            this.TxtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            this.TxtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(565, 62);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel1.TabIndex = 110;
            this.ambiance_HeaderLabel1.Text = "*";
            // 
            // ambiance_HeaderLabel2
            // 
            this.ambiance_HeaderLabel2.AutoSize = true;
            this.ambiance_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel2.Location = new System.Drawing.Point(127, 70);
            this.ambiance_HeaderLabel2.Name = "ambiance_HeaderLabel2";
            this.ambiance_HeaderLabel2.Size = new System.Drawing.Size(55, 20);
            this.ambiance_HeaderLabel2.TabIndex = 109;
            this.ambiance_HeaderLabel2.Text = "Name:";
            // 
            // Txtname
            // 
            this.Txtname.BackColor = System.Drawing.Color.Transparent;
            this.Txtname.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Txtname.ForeColor = System.Drawing.Color.DimGray;
            this.Txtname.Location = new System.Drawing.Point(205, 66);
            this.Txtname.MaxLength = 32767;
            this.Txtname.Multiline = false;
            this.Txtname.Name = "Txtname";
            this.Txtname.ReadOnly = false;
            this.Txtname.Size = new System.Drawing.Size(349, 28);
            this.Txtname.TabIndex = 108;
            this.Txtname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txtname.UseSystemPasswordChar = false;
            this.Txtname.TextChanged += new System.EventHandler(this.Txtname_TextChanged);
            // 
            // ambiance_HeaderLabel25
            // 
            this.ambiance_HeaderLabel25.AutoSize = true;
            this.ambiance_HeaderLabel25.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel25.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel25.Location = new System.Drawing.Point(565, 23);
            this.ambiance_HeaderLabel25.Name = "ambiance_HeaderLabel25";
            this.ambiance_HeaderLabel25.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel25.TabIndex = 107;
            this.ambiance_HeaderLabel25.Text = "*";
            // 
            // ambiance_HeaderLabel34
            // 
            this.ambiance_HeaderLabel34.AutoSize = true;
            this.ambiance_HeaderLabel34.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel34.Location = new System.Drawing.Point(129, 27);
            this.ambiance_HeaderLabel34.Name = "ambiance_HeaderLabel34";
            this.ambiance_HeaderLabel34.Size = new System.Drawing.Size(53, 20);
            this.ambiance_HeaderLabel34.TabIndex = 106;
            this.ambiance_HeaderLabel34.Text = "Mode:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.Image = null;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(205, 291);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 30);
            this.BtnSave.TabIndex = 105;
            this.BtnSave.Text = "ADD MODE";
            this.BtnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Image = null;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(410, 291);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 30);
            this.BtnCancel.TabIndex = 104;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.LblMsg_One);
            this.tabPage3.Controls.Add(this.ambiance_HeaderLabel5);
            this.tabPage3.Controls.Add(this.BtnAddMode);
            this.tabPage3.Controls.Add(this.BtnCancelMode);
            this.tabPage3.Controls.Add(this.ambiance_HeaderLabel3);
            this.tabPage3.Controls.Add(this.TxtMode);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(678, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modes";
            // 
            // LblMsg_One
            // 
            this.LblMsg_One.AutoSize = true;
            this.LblMsg_One.BackColor = System.Drawing.Color.Transparent;
            this.LblMsg_One.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblMsg_One.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.LblMsg_One.Location = new System.Drawing.Point(201, 66);
            this.LblMsg_One.Name = "LblMsg_One";
            this.LblMsg_One.Size = new System.Drawing.Size(252, 19);
            this.LblMsg_One.TabIndex = 134;
            this.LblMsg_One.Text = "All mandatory (*) fields should filled";
            // 
            // ambiance_HeaderLabel5
            // 
            this.ambiance_HeaderLabel5.AutoSize = true;
            this.ambiance_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel5.Location = new System.Drawing.Point(560, 17);
            this.ambiance_HeaderLabel5.Name = "ambiance_HeaderLabel5";
            this.ambiance_HeaderLabel5.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel5.TabIndex = 110;
            this.ambiance_HeaderLabel5.Text = "*";
            // 
            // BtnAddMode
            // 
            this.BtnAddMode.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnAddMode.Image = null;
            this.BtnAddMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddMode.Location = new System.Drawing.Point(205, 106);
            this.BtnAddMode.Name = "BtnAddMode";
            this.BtnAddMode.Size = new System.Drawing.Size(144, 30);
            this.BtnAddMode.TabIndex = 109;
            this.BtnAddMode.Text = "ADD MODE";
            this.BtnAddMode.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAddMode.Click += new System.EventHandler(this.BtnAddMode_Click);
            // 
            // BtnCancelMode
            // 
            this.BtnCancelMode.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancelMode.Image = null;
            this.BtnCancelMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelMode.Location = new System.Drawing.Point(410, 106);
            this.BtnCancelMode.Name = "BtnCancelMode";
            this.BtnCancelMode.Size = new System.Drawing.Size(144, 30);
            this.BtnCancelMode.TabIndex = 108;
            this.BtnCancelMode.Text = "Cancel";
            this.BtnCancelMode.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCancelMode.Click += new System.EventHandler(this.BtnCancelMode_Click);
            // 
            // ambiance_HeaderLabel3
            // 
            this.ambiance_HeaderLabel3.AutoSize = true;
            this.ambiance_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel3.Location = new System.Drawing.Point(129, 27);
            this.ambiance_HeaderLabel3.Name = "ambiance_HeaderLabel3";
            this.ambiance_HeaderLabel3.Size = new System.Drawing.Size(53, 20);
            this.ambiance_HeaderLabel3.TabIndex = 107;
            this.ambiance_HeaderLabel3.Text = "Mode:";
            // 
            // TxtMode
            // 
            this.TxtMode.BackColor = System.Drawing.Color.Transparent;
            this.TxtMode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMode.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMode.Location = new System.Drawing.Point(205, 26);
            this.TxtMode.MaxLength = 32767;
            this.TxtMode.Multiline = false;
            this.TxtMode.Name = "TxtMode";
            this.TxtMode.ReadOnly = false;
            this.TxtMode.Size = new System.Drawing.Size(349, 28);
            this.TxtMode.TabIndex = 104;
            this.TxtMode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMode.UseSystemPasswordChar = false;
            this.TxtMode.TextChanged += new System.EventHandler(this.TxtMode_TextChanged);
            // 
            // LblPositon
            // 
            this.LblPositon.AutoSize = true;
            this.LblPositon.BackColor = System.Drawing.Color.Transparent;
            this.LblPositon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblPositon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblPositon.Location = new System.Drawing.Point(12, 9);
            this.LblPositon.Name = "LblPositon";
            this.LblPositon.Size = new System.Drawing.Size(155, 20);
            this.LblPositon.TabIndex = 66;
            this.LblPositon.Text = "PAYMENT METHODS";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 417);
            this.Controls.Add(this.LblPositon);
            this.Controls.Add(this.ambiance_TabControl1);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ambiance_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnClose;
        private Ambiance.Ambiance_TabControl ambiance_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Ambiance.Ambiance_HeaderLabel LblPositon;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel4;
        private Ambiance.Ambiance_TextBox TxtNum;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel2;
        private Ambiance.Ambiance_TextBox Txtname;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel25;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel34;
        private Ambiance.Ambiance_Button_1 BtnSave;
        private Ambiance.Ambiance_Button_1 BtnCancel;
        private Ambiance.Ambiance_ComboBox CmbMode;
        private System.Windows.Forms.TabPage tabPage3;
        private Ambiance.Ambiance_Button_1 BtnAddMode;
        private Ambiance.Ambiance_Button_1 BtnCancelMode;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel3;
        private Ambiance.Ambiance_TextBox TxtMode;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel5;
        private Ambiance.Ambiance_HeaderLabel LblMsg;
        private Ambiance.Ambiance_HeaderLabel LblMsg_One;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel7;
    }
}