namespace SPC_Managememt_System
{
    partial class Directory
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
            this.ambiance_RichTextBox1 = new Ambiance.Ambiance_RichTextBox();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.SuspendLayout();
            // 
            // ambiance_RichTextBox1
            // 
            this.ambiance_RichTextBox1.AutoWordSelection = false;
            this.ambiance_RichTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_RichTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ambiance_RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ambiance_RichTextBox1.Location = new System.Drawing.Point(12, 48);
            this.ambiance_RichTextBox1.Name = "ambiance_RichTextBox1";
            this.ambiance_RichTextBox1.ReadOnly = false;
            this.ambiance_RichTextBox1.Size = new System.Drawing.Size(286, 195);
            this.ambiance_RichTextBox1.TabIndex = 0;
            this.ambiance_RichTextBox1.WordWrap = true;
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.Location = new System.Drawing.Point(12, 12);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(286, 30);
            this.ambiance_Button_11.TabIndex = 1;
            this.ambiance_Button_11.Text = "ambiance_Button_11";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.Ambiance_Button_11_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 255);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.ambiance_RichTextBox1);
            this.Name = "Directory";
            this.Text = "Directory";
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_RichTextBox ambiance_RichTextBox1;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
    }
}