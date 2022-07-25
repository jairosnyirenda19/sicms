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
    public partial class Standard_Interface : UserControl
    {
        public static string Propagation
        {
            get;
            private set;
        }
        public Standard_Interface()
        {
            InitializeComponent();
        }

        private void Standard_Interface_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void BtnAddStd_Click(object sender, EventArgs e)
        {
            var x = new Standard(TxtStdName.Text, TxtAgencyAppro.Text, RichTxtDescription.Text);
            x.AddUmbrellaStandard();
            BtnClear_Click(sender, e);
            _Load();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtStdName.Text = "";
            TxtAgencyAppro.Text = "";
            RichTxtDescription.Text = "";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ComboPropagationType.Text == "Seed Propagation")
                _standard_seed_propagation1.Visible = true;
            else
                MessageBox.Show("Unfornately these propagation types currently are not supported","SPCMS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void ComboStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboPropagationType.Items.Clear();
            string[] Condition = new[] { "std_id", "=", Standard.standard_id[ComboStandard.SelectedIndex]};
            DB.GetInstance().Get("standard_propagation_type", Condition);
            if (DB.GetInstance().dt.Rows.Count > 0)
                for (int i = 0; i < DB.GetInstance().dt.Rows.Count; i++)
                    ComboPropagationType.Items.Add(DB.GetInstance().dt.Rows[i][2].ToString());
            else
                MessageBox.Show("This selected standard has no propagation types available","SPCMS",MessageBoxButtons.OK, MessageBoxIcon.Error);
            _ValidationHelper();
        }

        private void ComboPropagationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Propagation = ComboPropagationType.Text;
            _ValidationHelper();
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            if (_ValidateStandard())
            {
                BtnAddStd.Enabled = true;
                BtnAddStd.Cursor = Cursors.Hand;
                LblMsg.Visible = false;
            }
            else
            {
                BtnAddStd.Enabled = false;
                BtnAddStd.Cursor = Cursors.No;
                LblMsg.Visible = true;
            }
        }

        private bool _ValidateStandard()
        {
            if (TxtAgencyAppro.Text != "" && TxtStdName.Text != "")
                return true;
            else
                return false;
        }

        private bool _Validation()
        {
            if (ComboStandard.Text != "" && ComboPropagationType.Text != "")
                return true;
            return false;
        }

        private void _ValidationHelper()
        {
            if (_Validation())
            {
                BtnNext.Enabled = true;
                BtnNext.Cursor = Cursors.Hand;
            }
            else
            {
                BtnNext.Enabled = false;
                BtnNext.Cursor = Cursors.No;
            }
        }

        public static void ExecuteLoad()
        {
            Standard_Interface @interface = new Standard_Interface();
            @interface._Load();
        }

        public void _Load()
        {               
            List<string> x = new List<string>();
            DataTable dt = new DataTable();
            DataTable dtCount = new DataTable();
            string Query = string.Empty;
            DataGridStandards.Rows.Clear();
            DataGridCropStandard.Rows.Clear();            
            ComboStandard.Items.Clear();

            Query = "SELECT * FROM Standard";
            dt = DB.GetInstance().Query(Query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int count = 0;
                int rows = DataGridStandards.Rows.Add();
                DataGridStandards.Rows[rows].Cells[0].Value = dt.Rows[i][1].ToString();
                DataGridStandards.Rows[rows].Cells[1].Value = dt.Rows[i][2].ToString();
                DataGridStandards.Rows[rows].Cells[2].Value = dt.Rows[i][3].ToString();
                string[] Condition = new[] { "std_id", "=", dt.Rows[i][0].ToString() };
                DB.GetInstance().Get("standard_propagation_type", Condition);
                dtCount = DB.GetInstance().dt;
                for (int z = 0; z < dt.Rows.Count; z++)
                {
                    Condition = new[] { "propagation_type_id", "=", dt.Rows[i][0].ToString() };
                    DB.GetInstance().Get("propagation_seed_standard", Condition);
                    count = count + DB.GetInstance().dt.Rows.Count;

                    Condition = new[] { "propagation_type_id", "=", dt.Rows[i][0].ToString() };
                    DB.GetInstance().Get("propagation_tuber_standard", Condition);
                    count = count + DB.GetInstance().dt.Rows.Count;

                    Condition = new[] { "propagation_type_id", "=", dt.Rows[i][0].ToString() };
                    DB.GetInstance().Get("propagation_grass_standard", Condition);
                    count = count + DB.GetInstance().dt.Rows.Count; 
                }
                DataGridStandards.Rows[rows].Cells[3].Value = count.ToString();
            }

            Query = "SELECT * FROM propagation_seed_standard";
            dt = DB.GetInstance().Query(Query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int rows = DataGridCropStandard.Rows.Add();
                string[] Condition = new[] { "crop_id", "=", dt.Rows[i]["crop_id"].ToString() };
                DB.GetInstance().Get("crop", Condition);                
                DataGridCropStandard.Rows[rows].Cells[0].Value = DB.GetInstance().dt.Rows[0]["crop_name"].ToString();

                Condition = new[] { "class_id", "=", dt.Rows[i][1].ToString() };
                DB.GetInstance().Get("class", Condition);
                DataGridCropStandard.Rows[rows].Cells[1].Value = DB.GetInstance().dt.Rows[0][1].ToString();

                Query = "SELECT * FROM sowing_report WHERE crop_id = @a AND class_id = @b";
                string[] _data = new[]{ dt.Rows[i][2].ToString(), dt.Rows[i][1].ToString() };
                DataGridCropStandard.Rows[rows].Cells[2].Value = DB.GetInstance().GetCompoundCondition(Query, _data).Rows.Count.ToString();
            }

            x = Standard.Combo("SELECT * FROM standard");
            for (int i = 0; i < x.Count; i++)
                ComboStandard.Items.Add(x[i]);
        }
    }
}
