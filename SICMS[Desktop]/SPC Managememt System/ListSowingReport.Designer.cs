namespace SPC_Managememt_System
{
    partial class ListSowingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSowingReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblState = new Ambiance.Ambiance_HeaderLabel();
            this.LblDate = new Ambiance.Ambiance_Label();
            this.LblSeed = new Ambiance.Ambiance_Label();
            this.LblName = new Ambiance.Ambiance_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 88);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 2);
            this.panel2.TabIndex = 9;
            this.panel2.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            // 
            // LblState
            // 
            this.LblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblState.AutoSize = true;
            this.LblState.BackColor = System.Drawing.Color.Transparent;
            this.LblState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.LblState.Location = new System.Drawing.Point(282, 58);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(44, 20);
            this.LblState.TabIndex = 8;
            this.LblState.Text = "NEW";
            this.LblState.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.LblState.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LblDate.Location = new System.Drawing.Point(85, 58);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(35, 17);
            this.LblDate.TabIndex = 7;
            this.LblDate.Text = "Date";
            this.LblDate.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.LblDate.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
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
            this.LblSeed.TabIndex = 6;
            this.LblSeed.Text = "Seed Produced:";
            this.LblSeed.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.LblSeed.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
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
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            this.LblName.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.LblName.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            // 
            // ListSowingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblSeed);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.panel1);
            this.Name = "ListSowingReport";
            this.Size = new System.Drawing.Size(338, 88);
            this.MouseEnter += new System.EventHandler(this.ListSowingReport_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListSowingReport_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Ambiance.Ambiance_HeaderLabel LblName;
        private Ambiance.Ambiance_Label LblSeed;
        private Ambiance.Ambiance_Label LblDate;
        private Ambiance.Ambiance_HeaderLabel LblState;
        private System.Windows.Forms.Panel panel2;
    }
}
