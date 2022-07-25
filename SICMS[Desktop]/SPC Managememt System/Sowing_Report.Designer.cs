namespace SPC_Managememt_System
{
    partial class Sowing_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sowing_Report));
            this.BtnAppExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnWindowSize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.WindowSizeImageList = new System.Windows.Forms.ImageList(this.components);
            this.FlwInspections = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwSowingThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlActionControls = new System.Windows.Forms.Panel();
            this.FlwSowingReport = new System.Windows.Forms.Panel();
            this.CmbInspection = new System.Windows.Forms.ComboBox();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAppExit
            // 
            this.BtnAppExit.Active = false;
            this.BtnAppExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnAppExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppExit.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnAppExit.Location = new System.Drawing.Point(1133, 0);
            this.BtnAppExit.Name = "BtnAppExit";
            this.BtnAppExit.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnAppExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnAppExit.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAppExit.selected = false;
            this.BtnAppExit.Size = new System.Drawing.Size(35, 35);
            this.BtnAppExit.TabIndex = 4;
            this.BtnAppExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppExit.Textcolor = System.Drawing.Color.White;
            this.BtnAppExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppExit.Click += new System.EventHandler(this.BtnAppExit_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Controls.Add(this.BtnWindowSize);
            this.PnlHeader.Controls.Add(this.BtnAppExit);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1180, 35);
            this.PnlHeader.TabIndex = 5;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sowing Reports";
            // 
            // BtnWindowSize
            // 
            this.BtnWindowSize.Active = false;
            this.BtnWindowSize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowSize.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnWindowSize.Location = new System.Drawing.Point(1092, 0);
            this.BtnWindowSize.Name = "BtnWindowSize";
            this.BtnWindowSize.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnWindowSize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(45)))));
            this.BtnWindowSize.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnWindowSize.selected = false;
            this.BtnWindowSize.Size = new System.Drawing.Size(35, 35);
            this.BtnWindowSize.TabIndex = 5;
            this.BtnWindowSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWindowSize.Textcolor = System.Drawing.Color.White;
            this.BtnWindowSize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWindowSize.Click += new System.EventHandler(this.BtnWindowSize_Click);
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
            // FlwInspections
            // 
            this.FlwInspections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlwInspections.AutoScroll = true;
            this.FlwInspections.Location = new System.Drawing.Point(793, 64);
            this.FlwInspections.Name = "FlwInspections";
            this.FlwInspections.Size = new System.Drawing.Size(380, 460);
            this.FlwInspections.TabIndex = 92;
            // 
            // FlwSowingThumbnails
            // 
            this.FlwSowingThumbnails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwSowingThumbnails.AutoScroll = true;
            this.FlwSowingThumbnails.Location = new System.Drawing.Point(12, 64);
            this.FlwSowingThumbnails.Name = "FlwSowingThumbnails";
            this.FlwSowingThumbnails.Size = new System.Drawing.Size(340, 460);
            this.FlwSowingThumbnails.TabIndex = 92;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // PnlActionControls
            // 
            this.PnlActionControls.Location = new System.Drawing.Point(407, 64);
            this.PnlActionControls.Name = "PnlActionControls";
            this.PnlActionControls.Size = new System.Drawing.Size(380, 147);
            this.PnlActionControls.TabIndex = 94;
            // 
            // FlwSowingReport
            // 
            this.FlwSowingReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwSowingReport.AutoScroll = true;
            this.FlwSowingReport.Location = new System.Drawing.Point(406, 252);
            this.FlwSowingReport.Name = "FlwSowingReport";
            this.FlwSowingReport.Size = new System.Drawing.Size(380, 272);
            this.FlwSowingReport.TabIndex = 95;
            // 
            // CmbInspection
            // 
            this.CmbInspection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbInspection.FormattingEnabled = true;
            this.CmbInspection.Location = new System.Drawing.Point(406, 217);
            this.CmbInspection.Name = "CmbInspection";
            this.CmbInspection.Size = new System.Drawing.Size(380, 29);
            this.CmbInspection.TabIndex = 97;
            this.CmbInspection.SelectedIndexChanged += new System.EventHandler(this.CmbInspection_SelectedIndexChanged_1);
            // 
            // Sowing_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1180, 536);
            this.Controls.Add(this.CmbInspection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FlwSowingThumbnails);
            this.Controls.Add(this.FlwInspections);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.PnlActionControls);
            this.Controls.Add(this.FlwSowingReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sowing_Report";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sowing_Report";
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnAppExit;
        private System.Windows.Forms.Panel PnlHeader;
        private Bunifu.Framework.UI.BunifuFlatButton BtnWindowSize;
        private System.Windows.Forms.ImageList WindowSizeImageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FlwInspections;
        private System.Windows.Forms.FlowLayoutPanel FlwSowingThumbnails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlActionControls;
        private System.Windows.Forms.Panel FlwSowingReport;
        private System.Windows.Forms.ComboBox CmbInspection;
    }
}