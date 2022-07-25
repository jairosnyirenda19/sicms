using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    class Seed
    {
        private int seed_id;
        private string seed;
        private string[] variety;

        public Seed()
        {

        }

        public Seed(string seed, string[] variety)
        {
            this.seed = seed;
            this.variety = variety;
        }

        public bool AddSeed()
        {
            var x = new Dictionary<string, string>();
            string[] Condition = new[] { "crop_name", "=", seed };
            DB.GetInstance().Get("crop", Condition);
            if (DB.GetInstance().dt.Rows.Count > 0)
            {
                MessageBox.Show("This crop already exists, please add a new one", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            x.Add("crop_name", seed);
            bool proceed = DB.GetInstance().Insert("crop", x);
            if (proceed)
            {
                Condition = new[] { "crop_name", "=", seed };
                DB.GetInstance().Get("crop", Condition);
                seed_id = Int32.Parse(DB.GetInstance().dt.Rows[0][0].ToString());
               
                for (int i = 0; i < variety.Length; i++)
                {
                    x = new Dictionary<string, string>();
                    x.Add("crop_id", seed_id.ToString());
                    x.Add("variety_name", variety[i]);
                    DB.GetInstance().Insert("variety", x);
                }
                MessageBox.Show("The crop "+seed+" and varities under it have been added successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return true;
        }

        public static List<string> Combo(string Query)
        {
            List<string> x = new List<string>();
            DataTable dt = DB.GetInstance().Query(Query);
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                    x.Add(dt.Rows[i][1].ToString());                
            return x;
        }


    }
}
