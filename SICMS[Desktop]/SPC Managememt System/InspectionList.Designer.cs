namespace SPC_Managememt_System
{
    partial class InspectionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionList));
            this.BtnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalInspection = new Ambiance.Ambiance_HeaderLabel();
            this.lblpreflowering = new Ambiance.Ambiance_LinkLabel();
            this.lblflowering = new Ambiance.Ambiance_LinkLabel();
            this.lblpostflowering = new Ambiance.Ambiance_LinkLabel();
            this.lblharvest = new Ambiance.Ambiance_LinkLabel();
            this.lblTitle = new Ambiance.Ambiance_HeaderLabel();
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
            this.BtnClose.Location = new System.Drawing.Point(276, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClose.selected = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 51;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Textcolor = System.Drawing.Color.White;
            this.BtnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTotalInspection
            // 
            this.lblTotalInspection.AutoSize = true;
            this.lblTotalInspection.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalInspection.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInspection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTotalInspection.Location = new System.Drawing.Point(24, 45);
            this.lblTotalInspection.Name = "lblTotalInspection";
            this.lblTotalInspection.Size = new System.Drawing.Size(161, 17);
            this.lblTotalInspection.TabIndex = 57;
            this.lblTotalInspection.Text = "Inspections Conducted: 4";
            // 
            // lblpreflowering
            // 
            this.lblpreflowering.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lblpreflowering.AutoSize = true;
            this.lblpreflowering.BackColor = System.Drawing.Color.Transparent;
            this.lblpreflowering.Enabled = false;
            this.lblpreflowering.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblpreflowering.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblpreflowering.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblpreflowering.Location = new System.Drawing.Point(25, 82);
            this.lblpreflowering.Name = "lblpreflowering";
            this.lblpreflowering.Size = new System.Drawing.Size(171, 20);
            this.lblpreflowering.TabIndex = 53;
            this.lblpreflowering.TabStop = true;
            this.lblpreflowering.Text = "Pre Flowering Inspection";
            this.lblpreflowering.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblpreflowering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lblpreflowering_LinkClicked);
            // 
            // lblflowering
            // 
            this.lblflowering.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lblflowering.AutoSize = true;
            this.lblflowering.BackColor = System.Drawing.Color.Transparent;
            this.lblflowering.Enabled = false;
            this.lblflowering.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblflowering.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblflowering.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblflowering.Location = new System.Drawing.Point(25, 113);
            this.lblflowering.Name = "lblflowering";
            this.lblflowering.Size = new System.Drawing.Size(146, 20);
            this.lblflowering.TabIndex = 54;
            this.lblflowering.TabStop = true;
            this.lblflowering.Text = "Flowering Inspection";
            this.lblflowering.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblflowering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lblflowering_LinkClicked);
            // 
            // lblpostflowering
            // 
            this.lblpostflowering.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lblpostflowering.AutoSize = true;
            this.lblpostflowering.BackColor = System.Drawing.Color.Transparent;
            this.lblpostflowering.Enabled = false;
            this.lblpostflowering.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblpostflowering.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblpostflowering.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblpostflowering.Location = new System.Drawing.Point(25, 146);
            this.lblpostflowering.Name = "lblpostflowering";
            this.lblpostflowering.Size = new System.Drawing.Size(177, 20);
            this.lblpostflowering.TabIndex = 55;
            this.lblpostflowering.TabStop = true;
            this.lblpostflowering.Text = "Post Flowering Inspection";
            this.lblpostflowering.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblpostflowering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lblpostflowering_LinkClicked);
            // 
            // lblharvest
            // 
            this.lblharvest.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lblharvest.AutoSize = true;
            this.lblharvest.BackColor = System.Drawing.Color.Transparent;
            this.lblharvest.Enabled = false;
            this.lblharvest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblharvest.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblharvest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblharvest.Location = new System.Drawing.Point(25, 177);
            this.lblharvest.Name = "lblharvest";
            this.lblharvest.Size = new System.Drawing.Size(131, 20);
            this.lblharvest.TabIndex = 56;
            this.lblharvest.TabStop = true;
            this.lblharvest.Text = "Harvest Inspection";
            this.lblharvest.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lblharvest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lblharvest_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 25);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Inspection Data Available";
            // 
            // InspectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 400);
            this.Controls.Add(this.lblTotalInspection);
            this.Controls.Add(this.lblpreflowering);
            this.Controls.Add(this.lblflowering);
            this.Controls.Add(this.lblpostflowering);
            this.Controls.Add(this.lblharvest);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectionList";
            this.Load += new System.EventHandler(this.InspectionList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnClose;
        private Ambiance.Ambiance_HeaderLabel lblTitle;
        private Ambiance.Ambiance_LinkLabel lblpreflowering;
        private Ambiance.Ambiance_LinkLabel lblflowering;
        private Ambiance.Ambiance_LinkLabel lblpostflowering;
        private Ambiance.Ambiance_LinkLabel lblharvest;
        private Ambiance.Ambiance_HeaderLabel lblTotalInspection;
    }
}