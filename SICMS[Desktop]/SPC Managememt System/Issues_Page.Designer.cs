namespace SPC_Managememt_System
{
    partial class Issues_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issues_Page));
            this.FlowPnlIssues = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new Ambiance.Ambiance_HeaderLabel();
            this.lblnumInspections = new Ambiance.Ambiance_HeaderLabel();
            this.lblTotIssues = new Ambiance.Ambiance_HeaderLabel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblpercent = new Ambiance.Ambiance_HeaderLabel();
            this.SuspendLayout();
            // 
            // FlowPnlIssues
            // 
            this.FlowPnlIssues.AutoScroll = true;
            this.FlowPnlIssues.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlowPnlIssues.Location = new System.Drawing.Point(12, 119);
            this.FlowPnlIssues.Name = "FlowPnlIssues";
            this.FlowPnlIssues.Size = new System.Drawing.Size(541, 319);
            this.FlowPnlIssues.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 25);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "Inspection Analysis Recommendation Report";
            // 
            // lblnumInspections
            // 
            this.lblnumInspections.AutoSize = true;
            this.lblnumInspections.BackColor = System.Drawing.Color.Transparent;
            this.lblnumInspections.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumInspections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblnumInspections.Location = new System.Drawing.Point(344, 46);
            this.lblnumInspections.Name = "lblnumInspections";
            this.lblnumInspections.Size = new System.Drawing.Size(169, 21);
            this.lblnumInspections.TabIndex = 47;
            this.lblnumInspections.Text = "From (3) Inspection(s)";
            // 
            // lblTotIssues
            // 
            this.lblTotIssues.AutoSize = true;
            this.lblTotIssues.BackColor = System.Drawing.Color.Transparent;
            this.lblTotIssues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTotIssues.Location = new System.Drawing.Point(12, 46);
            this.lblTotIssues.Name = "lblTotIssues";
            this.lblTotIssues.Size = new System.Drawing.Size(110, 21);
            this.lblTotIssues.TabIndex = 49;
            this.lblTotIssues.Text = "Total Issues: 0";
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
            this.BtnClose.Location = new System.Drawing.Point(529, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClose.selected = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 50;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Textcolor = System.Drawing.Color.White;
            this.BtnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.BackColor = System.Drawing.Color.Transparent;
            this.lblpercent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblpercent.Location = new System.Drawing.Point(12, 81);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(193, 21);
            this.lblpercent.TabIndex = 51;
            this.lblpercent.Text = "Analysis Percentage: 90%";
            // 
            // Issues_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.lblpercent);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblTotIssues);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblnumInspections);
            this.Controls.Add(this.FlowPnlIssues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Issues_Page";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issues_Page";
            this.Load += new System.EventHandler(this.Issues_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPnlIssues;
        private Ambiance.Ambiance_HeaderLabel lblTitle;
        private Ambiance.Ambiance_HeaderLabel lblnumInspections;
        private Ambiance.Ambiance_HeaderLabel lblTotIssues;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClose;
        private Ambiance.Ambiance_HeaderLabel lblpercent;
    }
}