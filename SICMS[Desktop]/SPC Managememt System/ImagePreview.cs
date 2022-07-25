using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class ImagePreview : Form
    {
        int mov, movX, movY;
        int ButtonClickCount = 0;
        int ButtonClickChecker = 0;
        public ImagePreview(string path)
        {
            InitializeComponent();
            KpImageViewer.imagepath = path;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
        private void BtnAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}