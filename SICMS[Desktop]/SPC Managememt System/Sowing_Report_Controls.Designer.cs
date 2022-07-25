namespace SPC_Managememt_System
{
    partial class Sowing_Report_Controls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sowing_Report_Controls));
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.BtnGenerateCertificationNO = new Ambiance.Ambiance_Button_2();
            this.BtnActionRecommendation = new Ambiance.Ambiance_Button_1();
            this.BtnDisqualify = new Ambiance.Ambiance_Button_2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(3, 8);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(74, 20);
            this.ambiance_HeaderLabel1.TabIndex = 0;
            this.ambiance_HeaderLabel1.Text = "ACTIONS";
            // 
            // BtnGenerateCertificationNO
            // 
            this.BtnGenerateCertificationNO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateCertificationNO.BackColor = System.Drawing.Color.Transparent;
            this.BtnGenerateCertificationNO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BtnGenerateCertificationNO.Image = null;
            this.BtnGenerateCertificationNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerateCertificationNO.Location = new System.Drawing.Point(48, 73);
            this.BtnGenerateCertificationNO.Name = "BtnGenerateCertificationNO";
            this.BtnGenerateCertificationNO.Size = new System.Drawing.Size(272, 30);
            this.BtnGenerateCertificationNO.TabIndex = 1;
            this.BtnGenerateCertificationNO.Text = "Grant Certification";
            this.BtnGenerateCertificationNO.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnGenerateCertificationNO.Click += new System.EventHandler(this.BtnGenerateCertificationNO_Click);
            // 
            // BtnActionRecommendation
            // 
            this.BtnActionRecommendation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActionRecommendation.BackColor = System.Drawing.Color.Transparent;
            this.BtnActionRecommendation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnActionRecommendation.Image = null;
            this.BtnActionRecommendation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActionRecommendation.Location = new System.Drawing.Point(48, 37);
            this.BtnActionRecommendation.Name = "BtnActionRecommendation";
            this.BtnActionRecommendation.Size = new System.Drawing.Size(272, 30);
            this.BtnActionRecommendation.TabIndex = 2;
            this.BtnActionRecommendation.Text = "ACTION RECOMMENDATION";
            this.BtnActionRecommendation.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnActionRecommendation.Click += new System.EventHandler(this.BtnActionRecommendation_Click);
            // 
            // BtnDisqualify
            // 
            this.BtnDisqualify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisqualify.BackColor = System.Drawing.Color.Transparent;
            this.BtnDisqualify.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDisqualify.Image = null;
            this.BtnDisqualify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisqualify.Location = new System.Drawing.Point(48, 109);
            this.BtnDisqualify.Name = "BtnDisqualify";
            this.BtnDisqualify.Size = new System.Drawing.Size(272, 30);
            this.BtnDisqualify.TabIndex = 3;
            this.BtnDisqualify.Text = "Disqualify";
            this.BtnDisqualify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDisqualify.Click += new System.EventHandler(this.BtnDisqualify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Sowing_Report_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDisqualify);
            this.Controls.Add(this.BtnActionRecommendation);
            this.Controls.Add(this.BtnGenerateCertificationNO);
            this.Controls.Add(this.ambiance_HeaderLabel1);
            this.Name = "Sowing_Report_Controls";
            this.Size = new System.Drawing.Size(369, 157);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_Button_2 BtnGenerateCertificationNO;
        private Ambiance.Ambiance_Button_1 BtnActionRecommendation;
        private Ambiance.Ambiance_Button_2 BtnDisqualify;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
