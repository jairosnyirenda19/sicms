namespace SPC_Managememt_System
{
    partial class Request_Pending
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDate = new Ambiance.Ambiance_Label();
            this.LblSeed = new Ambiance.Ambiance_Label();
            this.LblName = new Ambiance.Ambiance_HeaderLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblInspectionType = new Ambiance.Ambiance_Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 2);
            this.panel2.TabIndex = 15;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblDate.Location = new System.Drawing.Point(86, 72);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(35, 17);
            this.LblDate.TabIndex = 13;
            this.LblDate.Text = "Date";
            // 
            // LblSeed
            // 
            this.LblSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSeed.AutoEllipsis = true;
            this.LblSeed.BackColor = System.Drawing.Color.Transparent;
            this.LblSeed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblSeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblSeed.Location = new System.Drawing.Point(85, 32);
            this.LblSeed.Name = "LblSeed";
            this.LblSeed.Size = new System.Drawing.Size(250, 20);
            this.LblSeed.TabIndex = 12;
            this.LblSeed.Text = "Seed Produced:";
            // 
            // LblName
            // 
            this.LblName.AutoEllipsis = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblName.Location = new System.Drawing.Point(85, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(250, 23);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 94);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPC_Managememt_System.Properties.Resources.icons8_evidence_filled_45px;
            this.pictureBox1.Location = new System.Drawing.Point(15, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblInspectionType
            // 
            this.LblInspectionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInspectionType.AutoEllipsis = true;
            this.LblInspectionType.BackColor = System.Drawing.Color.Transparent;
            this.LblInspectionType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblInspectionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblInspectionType.Location = new System.Drawing.Point(85, 52);
            this.LblInspectionType.Name = "LblInspectionType";
            this.LblInspectionType.Size = new System.Drawing.Size(250, 20);
            this.LblInspectionType.TabIndex = 16;
            this.LblInspectionType.Text = "Inspection Type";
            // 
            // Request_Pending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblInspectionType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblSeed);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.panel1);
            this.Name = "Request_Pending";
            this.Size = new System.Drawing.Size(338, 94);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Ambiance.Ambiance_Label LblDate;
        private Ambiance.Ambiance_Label LblSeed;
        private Ambiance.Ambiance_HeaderLabel LblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Ambiance.Ambiance_Label LblInspectionType;
    }
}
