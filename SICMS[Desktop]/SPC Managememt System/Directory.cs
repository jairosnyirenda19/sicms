using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SPC_Managememt_System
{
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }

        private void Ambiance_Button_11_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                string x = folderBrowser.SelectedPath.ToString();
                ambiance_RichTextBox1.Text = x;
            }
        }

    }
}
