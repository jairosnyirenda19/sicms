namespace SPC_Managememt_System
{
    partial class Seeds_Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            ControlRenderer controlRenderer5 = new ControlRenderer();
            MSColorTable msColorTable5 = new MSColorTable();
            this.label1 = new System.Windows.Forms.Label();
            this.ambiance_TabControl1 = new Ambiance.Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridClients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ambiance_HeaderLabel3 = new Ambiance.Ambiance_HeaderLabel();
            this.LstVariety = new Ambiance.Ambiance_ListBox();
            this.ConMeStpVarietyList = new iTalk_ContextMenuStrip();
            this.removeVarietyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddVariety = new Ambiance.Ambiance_Button_1();
            this.BtnClear = new Ambiance.Ambiance_Button_1();
            this.LblMsg = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel5 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel4 = new Ambiance.Ambiance_HeaderLabel();
            this.BtnAddCrop = new Ambiance.Ambiance_Button_1();
            this.ambiance_HeaderLabel2 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.TxtVariety = new Ambiance.Ambiance_TextBox();
            this.TxtCrop = new Ambiance.Ambiance_TextBox();
            this.ambiance_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ConMeStpVarietyList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(798, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seeds";
            // 
            // ambiance_TabControl1
            // 
            this.ambiance_TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_TabControl1.Controls.Add(this.tabPage1);
            this.ambiance_TabControl1.Controls.Add(this.tabPage2);
            this.ambiance_TabControl1.ItemSize = new System.Drawing.Size(80, 24);
            this.ambiance_TabControl1.Location = new System.Drawing.Point(3, 30);
            this.ambiance_TabControl1.Name = "ambiance_TabControl1";
            this.ambiance_TabControl1.SelectedIndex = 0;
            this.ambiance_TabControl1.Size = new System.Drawing.Size(902, 433);
            this.ambiance_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.DataGridClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Seeds";
            // 
            // DataGridClients
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.DataGridClients.DoubleBuffered = true;
            this.DataGridClients.EnableHeadersVisualStyles = false;
            this.DataGridClients.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.DataGridClients.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridClients.Location = new System.Drawing.Point(3, 67);
            this.DataGridClients.Name = "DataGridClients";
            this.DataGridClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridClients.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridClients.Size = new System.Drawing.Size(888, 331);
            this.DataGridClients.TabIndex = 89;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Crop";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 150F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Variety";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Propagation Type";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel3);
            this.tabPage2.Controls.Add(this.LstVariety);
            this.tabPage2.Controls.Add(this.BtnAddVariety);
            this.tabPage2.Controls.Add(this.BtnClear);
            this.tabPage2.Controls.Add(this.LblMsg);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel5);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel4);
            this.tabPage2.Controls.Add(this.BtnAddCrop);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel2);
            this.tabPage2.Controls.Add(this.ambiance_HeaderLabel1);
            this.tabPage2.Controls.Add(this.TxtVariety);
            this.tabPage2.Controls.Add(this.TxtCrop);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Seeds";
            // 
            // ambiance_HeaderLabel3
            // 
            this.ambiance_HeaderLabel3.AutoSize = true;
            this.ambiance_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel3.Location = new System.Drawing.Point(175, 125);
            this.ambiance_HeaderLabel3.Name = "ambiance_HeaderLabel3";
            this.ambiance_HeaderLabel3.Size = new System.Drawing.Size(87, 20);
            this.ambiance_HeaderLabel3.TabIndex = 98;
            this.ambiance_HeaderLabel3.Text = "Variety List";
            // 
            // LstVariety
            // 
            this.LstVariety.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVariety.ContextMenuStrip = this.ConMeStpVarietyList;
            this.LstVariety.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LstVariety.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LstVariety.FormattingEnabled = true;
            this.LstVariety.IntegralHeight = false;
            this.LstVariety.ItemHeight = 18;
            this.LstVariety.Location = new System.Drawing.Point(327, 125);
            this.LstVariety.Name = "LstVariety";
            this.LstVariety.Size = new System.Drawing.Size(306, 96);
            this.LstVariety.TabIndex = 97;
            // 
            // ConMeStpVarietyList
            // 
            this.ConMeStpVarietyList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeVarietyToolStripMenuItem});
            this.ConMeStpVarietyList.Name = "ConMeStpVarietyList";
            controlRenderer5.ColorTable = msColorTable5;
            controlRenderer5.RoundedEdges = true;
            this.ConMeStpVarietyList.Renderer = controlRenderer5;
            this.ConMeStpVarietyList.Size = new System.Drawing.Size(156, 26);
            // 
            // removeVarietyToolStripMenuItem
            // 
            this.removeVarietyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.removeVarietyToolStripMenuItem.Name = "removeVarietyToolStripMenuItem";
            this.removeVarietyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.removeVarietyToolStripMenuItem.Text = "Remove Variety";
            this.removeVarietyToolStripMenuItem.Click += new System.EventHandler(this.RemoveVarietyToolStripMenuItem_Click);
            // 
            // BtnAddVariety
            // 
            this.BtnAddVariety.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddVariety.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddVariety.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddVariety.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAddVariety.Image = null;
            this.BtnAddVariety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddVariety.Location = new System.Drawing.Point(555, 78);
            this.BtnAddVariety.Name = "BtnAddVariety";
            this.BtnAddVariety.Size = new System.Drawing.Size(78, 30);
            this.BtnAddVariety.TabIndex = 93;
            this.BtnAddVariety.Text = "Add";
            this.BtnAddVariety.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAddVariety.Click += new System.EventHandler(this.BtnAddVariety_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClear.Image = null;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(486, 298);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(147, 30);
            this.BtnClear.TabIndex = 92;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.BackColor = System.Drawing.Color.Transparent;
            this.LblMsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.LblMsg.Location = new System.Drawing.Point(332, 259);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(252, 19);
            this.LblMsg.TabIndex = 91;
            this.LblMsg.Text = "All mandatory (*) fields should filled";
            // 
            // ambiance_HeaderLabel5
            // 
            this.ambiance_HeaderLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_HeaderLabel5.AutoSize = true;
            this.ambiance_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel5.Location = new System.Drawing.Point(639, 115);
            this.ambiance_HeaderLabel5.Name = "ambiance_HeaderLabel5";
            this.ambiance_HeaderLabel5.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel5.TabIndex = 90;
            this.ambiance_HeaderLabel5.Text = "*";
            // 
            // ambiance_HeaderLabel4
            // 
            this.ambiance_HeaderLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_HeaderLabel4.AutoSize = true;
            this.ambiance_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel4.Location = new System.Drawing.Point(639, 33);
            this.ambiance_HeaderLabel4.Name = "ambiance_HeaderLabel4";
            this.ambiance_HeaderLabel4.Size = new System.Drawing.Size(27, 32);
            this.ambiance_HeaderLabel4.TabIndex = 89;
            this.ambiance_HeaderLabel4.Text = "*";
            // 
            // BtnAddCrop
            // 
            this.BtnAddCrop.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddCrop.Enabled = false;
            this.BtnAddCrop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAddCrop.Image = null;
            this.BtnAddCrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCrop.Location = new System.Drawing.Point(327, 298);
            this.BtnAddCrop.Name = "BtnAddCrop";
            this.BtnAddCrop.Size = new System.Drawing.Size(147, 30);
            this.BtnAddCrop.TabIndex = 88;
            this.BtnAddCrop.Text = "Add Crop";
            this.BtnAddCrop.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAddCrop.Click += new System.EventHandler(this.BtnAddCrop_Click);
            // 
            // ambiance_HeaderLabel2
            // 
            this.ambiance_HeaderLabel2.AutoSize = true;
            this.ambiance_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel2.Location = new System.Drawing.Point(175, 85);
            this.ambiance_HeaderLabel2.Name = "ambiance_HeaderLabel2";
            this.ambiance_HeaderLabel2.Size = new System.Drawing.Size(58, 20);
            this.ambiance_HeaderLabel2.TabIndex = 87;
            this.ambiance_HeaderLabel2.Text = "Variety";
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(175, 41);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(42, 20);
            this.ambiance_HeaderLabel1.TabIndex = 86;
            this.ambiance_HeaderLabel1.Text = "Crop";
            // 
            // TxtVariety
            // 
            this.TxtVariety.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVariety.BackColor = System.Drawing.Color.Transparent;
            this.TxtVariety.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtVariety.ForeColor = System.Drawing.Color.DimGray;
            this.TxtVariety.Location = new System.Drawing.Point(327, 80);
            this.TxtVariety.MaxLength = 32767;
            this.TxtVariety.Multiline = false;
            this.TxtVariety.Name = "TxtVariety";
            this.TxtVariety.ReadOnly = false;
            this.TxtVariety.Size = new System.Drawing.Size(222, 28);
            this.TxtVariety.TabIndex = 85;
            this.TxtVariety.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtVariety.UseSystemPasswordChar = false;
            // 
            // TxtCrop
            // 
            this.TxtCrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCrop.BackColor = System.Drawing.Color.Transparent;
            this.TxtCrop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtCrop.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCrop.Location = new System.Drawing.Point(327, 37);
            this.TxtCrop.MaxLength = 32767;
            this.TxtCrop.Multiline = false;
            this.TxtCrop.Name = "TxtCrop";
            this.TxtCrop.ReadOnly = false;
            this.TxtCrop.Size = new System.Drawing.Size(306, 28);
            this.TxtCrop.TabIndex = 84;
            this.TxtCrop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCrop.UseSystemPasswordChar = false;
            this.TxtCrop.TextChanged += new System.EventHandler(this.TxtCrop_TextChanged);
            // 
            // Seeds_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ambiance_TabControl1);
            this.Name = "Seeds_Interface";
            this.Size = new System.Drawing.Size(908, 466);
            this.ambiance_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ConMeStpVarietyList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_TabControl ambiance_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Ambiance.Ambiance_Button_1 BtnClear;
        private Ambiance.Ambiance_HeaderLabel LblMsg;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel5;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel4;
        private Ambiance.Ambiance_Button_1 BtnAddCrop;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel2;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_TextBox TxtVariety;
        private Ambiance.Ambiance_TextBox TxtCrop;
        private Ambiance.Ambiance_Button_1 BtnAddVariety;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel3;
        private Ambiance.Ambiance_ListBox LstVariety;
        private iTalk_ContextMenuStrip ConMeStpVarietyList;
        private System.Windows.Forms.ToolStripMenuItem removeVarietyToolStripMenuItem;
    }
}
