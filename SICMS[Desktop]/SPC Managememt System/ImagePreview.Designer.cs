namespace SPC_Managememt_System
{
    partial class ImagePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePreview));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblImageTitle = new System.Windows.Forms.Label();
            this.BtnAppExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kpImageViewer1 = new SPC_Managememt_System.KpImageViewer();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.Black;
            this.PnlHeader.Controls.Add(this.LblImageTitle);
            this.PnlHeader.Controls.Add(this.BtnAppExit);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(985, 35);
            this.PnlHeader.TabIndex = 6;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // LblImageTitle
            // 
            this.LblImageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImageTitle.AutoSize = true;
            this.LblImageTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImageTitle.ForeColor = System.Drawing.Color.White;
            this.LblImageTitle.Location = new System.Drawing.Point(3, 6);
            this.LblImageTitle.Name = "LblImageTitle";
            this.LblImageTitle.Size = new System.Drawing.Size(121, 23);
            this.LblImageTitle.TabIndex = 6;
            this.LblImageTitle.Text = "Image View";
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
            this.BtnAppExit.Location = new System.Drawing.Point(938, 0);
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
            // kpImageViewer1
            // 
            this.kpImageViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kpImageViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.kpImageViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.kpImageViewer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kpImageViewer1.GifAnimation = false;
            this.kpImageViewer1.GifFPS = 15D;
            this.kpImageViewer1.Image = null;
            this.kpImageViewer1.Location = new System.Drawing.Point(0, 32);
            this.kpImageViewer1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.kpImageViewer1.MenuPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.kpImageViewer1.MinimumSize = new System.Drawing.Size(454, 157);
            this.kpImageViewer1.Name = "kpImageViewer1";
            this.kpImageViewer1.NavigationPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.kpImageViewer1.NavigationTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.OpenButton = true;
            this.kpImageViewer1.PreviewButton = true;
            this.kpImageViewer1.PreviewPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(85)))), ((int)(((byte)(82)))));
            this.kpImageViewer1.PreviewText = "Preview";
            this.kpImageViewer1.PreviewTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Rotation = 0;
            this.kpImageViewer1.Scrollbars = false;
            this.kpImageViewer1.ShowPreview = true;
            this.kpImageViewer1.Size = new System.Drawing.Size(985, 515);
            this.kpImageViewer1.TabIndex = 7;
            this.kpImageViewer1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Zoom = 100D;
            // 
            // ImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(985, 559);
            this.Controls.Add(this.kpImageViewer1);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImagePreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagePreview";
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblImageTitle;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAppExit;
        private KpImageViewer kpImageViewer1;
    }
}