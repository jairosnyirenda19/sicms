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
    public partial class _standard_seed_propagation : UserControl
    {
        public _standard_seed_propagation()
        {
            InitializeComponent();            
        }

        private void _standard_seed_propagation_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddStd_Click(object sender, EventArgs e)
        {
            double vapour = (TxtVapourContent.Text == "") ? 0 : Convert.ToDouble(TxtVapourContent.Text);
            Standard standard = new Standard(Standard_Interface.Propagation, ComboClass.Text, ComboCrop.Text, TxtInertMatter.Text, Convert.ToDouble(TxtPureSeed.Text),
            Convert.ToDouble(TxtOtherCropSeed.Text), Convert.ToDouble(TxtOtherWeedSeed.Text), Convert.ToDouble(TxtGerminationRate.Text), vapour, Convert.ToDouble(TxtVapourContent.Text), Convert.ToDouble(TxtIsolationDistance.Text), 
            Convert.ToDouble(TxtOtherCropPlants.Text), Convert.ToDouble(TxtOtherVarities.Text), Convert.ToDouble(TxtWeedPlants.Text), (TxtPlantInfected.Text == "") ? null : TxtPlantInfected.Text, (TxtGeneralCondition.Text == "") ? null : TxtGeneralCondition.Text);
            standard.AddStandard();
            BtnClear_Click(sender, e);
            Standard_Interface.ExecuteLoad();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtGeneralCondition.Text = "";
            TxtGerminationRate.Text = "";
            TxtInertMatter.Text = "";
            TxtIsolationDistance.Text = "";
            TxtMoistureContent.Text = "";
            TxtOtherCropPlants.Text = "";
            TxtOtherCropSeed.Text = "";
            TxtOtherVarities.Text = "";
            TxtOtherWeedSeed.Text = "";
            TxtPlantInfected.Text = "";
            TxtPureSeed.Text = "";
            TxtWeedPlants.Text = "";
            TxtVapourContent.Text = "";
            ComboClass.Text = "";
            ComboCrop.Text = "";
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            _ValidateHelper();
        }

        private void _SelectedIndexChanged(object sender, EventArgs e)
        {
            _ValidateHelper();
        }


        private bool _Validate()
        {
            if (TxtGeneralCondition.Text != "" && TxtGerminationRate.Text != "" && TxtInertMatter.Text != "" && TxtIsolationDistance.Text != "" && TxtMoistureContent.Text != "" &&
                TxtOtherCropPlants.Text != "" && TxtOtherCropSeed.Text != "" && TxtOtherVarities.Text != "" && TxtOtherWeedSeed.Text != "" && TxtPlantInfected.Text != "" &&
                TxtPureSeed.Text != "" && TxtWeedPlants.Text != "" && ComboClass.Text != "" && ComboCrop.Text != "")           
                    return true;            
            return false;
        }

        private void _ValidateHelper()
        {
            BtnAddStd.Enabled = (_Validate()) ? true : false;
            if (BtnAddStd.Enabled)
            {
                LblMsg.Visible = false;
                BtnAddStd.Cursor = Cursors.Hand;
            }
            else
            {
                LblMsg.Visible = true;
                BtnAddStd.Cursor = Cursors.No;
            }
        }

        private void _Load()
        {
            List<string> x = new List<string>();

            // # COMBO LOAD CROPS
            x = Seed.Combo("SELECT * FROM crop");
            for (int i = 0; i < x.Count; i++)
                ComboCrop.Items.Add(x[i]);

            // # COMBO LOAD CROPS
            x = Seed.Combo("SELECT * FROM class");
            for (int i = 0; i < x.Count; i++)
                ComboClass.Items.Add(x[i]);
        }


    }
}
