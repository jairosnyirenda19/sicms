namespace SPC_Managememt_System
{
    partial class DeclineRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeclineRequest));
            this.lblTitle = new Ambiance.Ambiance_HeaderLabel();
            this.RichTextReason = new Ambiance.Ambiance_RichTextBox();
            this.BtnFinish = new Ambiance.Ambiance_Button_1();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTitle.Location = new System.Drawing.Point(54, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 25);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Declining Request";
            // 
            // RichTextReason
            // 
            this.RichTextReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextReason.AutoWordSelection = false;
            this.RichTextReason.BackColor = System.Drawing.Color.Transparent;
            this.RichTextReason.Font = new System.Drawing.Font("Tahoma", 10F);
            this.RichTextReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.RichTextReason.Location = new System.Drawing.Point(12, 69);
            this.RichTextReason.Name = "RichTextReason";
            this.RichTextReason.ReadOnly = false;
            this.RichTextReason.Size = new System.Drawing.Size(288, 260);
            this.RichTextReason.TabIndex = 80;
            this.RichTextReason.WordWrap = true;
            // 
            // BtnFinish
            // 
            this.BtnFinish.BackColor = System.Drawing.Color.Transparent;
            this.BtnFinish.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnFinish.Image = null;
            this.BtnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinish.Location = new System.Drawing.Point(12, 344);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(169, 30);
            this.BtnFinish.TabIndex = 118;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(9, 41);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(70, 21);
            this.ambiance_HeaderLabel1.TabIndex = 119;
            this.ambiance_HeaderLabel1.Text = "Reasons";
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
            this.BtnClose.TabIndex = 53;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Textcolor = System.Drawing.Color.White;
            this.BtnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DeclineRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 400);
            this.Controls.Add(this.ambiance_HeaderLabel1);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.RichTextReason);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeclineRequest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeclineRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_HeaderLabel lblTitle;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClose;
        private Ambiance.Ambiance_RichTextBox RichTextReason;
        private Ambiance.Ambiance_Button_1 BtnFinish;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
    }
}