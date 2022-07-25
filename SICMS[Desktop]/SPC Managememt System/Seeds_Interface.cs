using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class Seeds_Interface : UserControl
    {
        public Seeds_Interface()
        {
            InitializeComponent();
        }

        private void TxtCrop_TextChanged(object sender, EventArgs e)
        {
            if (TxtCrop.Text == "")
                LstVariety.Items.Clear();
        }

        private void BtnAddVariety_Click(object sender, EventArgs e)
        {
            if(TxtCrop.Text == "")
            {
                MessageBox.Show("Please Enter the name of a crop first for these varities","SPCMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (TxtVariety.Text != "")
            {
                LstVariety.Items.Add(TxtVariety.Text);
                TxtVariety.Text = "";
                if (_Validate())
                {
                    BtnAddCrop.Enabled = true;
                    BtnAddCrop.Cursor = Cursors.Hand;
                }
            }            
        }

        private void BtnAddCrop_Click(object sender, EventArgs e)
        {
            var x = new string[LstVariety.Items.Count];
            for (int i = 0; i < x.Length; i++)
                x[i] = LstVariety.Items[i].ToString();
            Seed seed = new Seed(TxtCrop.Text, x);
            seed.AddSeed();
            BtnClear_Click(sender, e);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCrop.Text = "";
            TxtVariety.Text = "";
            LstVariety.Items.Clear();
            LblMsg.Visible = true;
            BtnAddCrop.Cursor = Cursors.No;
            BtnAddCrop.Enabled = false;
        }

        private void RemoveVarietyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = LstVariety.SelectedIndex;
            if (idx == 0 || idx > 0)
                LstVariety.Items.RemoveAt(idx);
            else if (LstVariety.Items.Count == 0)
                MessageBox.Show("There's not variety to remove", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please select the variety you want to remove", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!_Validate())
                BtnAddCrop.Enabled = false;
        }

        private bool _Validate()
        {
            if (TxtCrop.Text != "" && LstVariety.Items.Count > 0)
            {
                LblMsg.Visible = false;
                return true;
            }
            else
            {
                LblMsg.Visible = true;
                return false;
            }            
        }
    }
}
