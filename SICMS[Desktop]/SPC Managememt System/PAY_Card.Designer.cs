namespace SPC_Managememt_System
{
    partial class PAY_Card
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
            this.LblPositon = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.LblNum = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel39 = new Ambiance.Ambiance_HeaderLabel();
            this.LblMode = new Ambiance.Ambiance_HeaderLabel();
            this.LblName = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel4 = new Ambiance.Ambiance_HeaderLabel();
            this.SuspendLayout();
            // 
            // LblPositon
            // 
            this.LblPositon.AutoSize = true;
            this.LblPositon.BackColor = System.Drawing.Color.Transparent;
            this.LblPositon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblPositon.ForeColor = System.Drawing.Color.White;
            this.LblPositon.Location = new System.Drawing.Point(28, 13);
            this.LblPositon.Name = "LblPositon";
            this.LblPositon.Size = new System.Drawing.Size(127, 20);
            this.LblPositon.TabIndex = 65;
            this.LblPositon.Text = "PAYMENT MODE";
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.White;
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(28, 123);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(123, 20);
            this.ambiance_HeaderLabel1.TabIndex = 68;
            this.ambiance_HeaderLabel1.Text = "Acc #/ Mobile #:";
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.BackColor = System.Drawing.Color.Transparent;
            this.LblNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblNum.ForeColor = System.Drawing.Color.White;
            this.LblNum.Location = new System.Drawing.Point(160, 123);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(166, 20);
            this.LblNum.TabIndex = 69;
            this.LblNum.Text = "########### ######";
            // 
            // ambiance_HeaderLabel39
            // 
            this.ambiance_HeaderLabel39.AutoSize = true;
            this.ambiance_HeaderLabel39.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel39.ForeColor = System.Drawing.Color.White;
            this.ambiance_HeaderLabel39.Location = new System.Drawing.Point(98, 54);
            this.ambiance_HeaderLabel39.Name = "ambiance_HeaderLabel39";
            this.ambiance_HeaderLabel39.Size = new System.Drawing.Size(53, 20);
            this.ambiance_HeaderLabel39.TabIndex = 66;
            this.ambiance_HeaderLabel39.Text = "Mode:";
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.BackColor = System.Drawing.Color.Transparent;
            this.LblMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblMode.ForeColor = System.Drawing.Color.White;
            this.LblMode.Location = new System.Drawing.Point(160, 54);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(166, 20);
            this.LblMode.TabIndex = 67;
            this.LblMode.Text = "########### ######";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(160, 89);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(166, 20);
            this.LblName.TabIndex = 71;
            this.LblName.Text = "########### ######";
            // 
            // ambiance_HeaderLabel4
            // 
            this.ambiance_HeaderLabel4.AutoSize = true;
            this.ambiance_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel4.ForeColor = System.Drawing.Color.White;
            this.ambiance_HeaderLabel4.Location = new System.Drawing.Point(98, 89);
            this.ambiance_HeaderLabel4.Name = "ambiance_HeaderLabel4";
            this.ambiance_HeaderLabel4.Size = new System.Drawing.Size(55, 20);
            this.ambiance_HeaderLabel4.TabIndex = 70;
            this.ambiance_HeaderLabel4.Text = "Name:";
            // 
            // PAY_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(168)))));
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.ambiance_HeaderLabel4);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.ambiance_HeaderLabel1);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.ambiance_HeaderLabel39);
            this.Controls.Add(this.LblPositon);
            this.Name = "PAY_Card";
            this.Size = new System.Drawing.Size(661, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_HeaderLabel LblPositon;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_HeaderLabel LblNum;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel39;
        private Ambiance.Ambiance_HeaderLabel LblMode;
        private Ambiance.Ambiance_HeaderLabel LblName;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel4;
    }
}
