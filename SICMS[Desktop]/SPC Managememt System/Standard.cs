using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public class Standard : Analysis
    {
        public static List<string> standard_id;
        private string StandardName;
        private string ProgagationType;
        private string Class;
        private string Crop;
        private string InertMatter;
        private double Purity;
        private double Other_Crop_Seed;
        private double Total_Weed_seed;
        private double GeneminationRate;
        private double MoistureContent;
        private double MoistureContentVapour;

        public double Score { get; set; }
        public Dictionary<string, string> MainIssues { get; set; }

        // propagation_seed_field_standard

        private int seedStd_id;
        private double isolation_distance;
        private double other_crop_plants;
        private double other_varities;
        private double weed_plants;
        private string plant_infected;
        private string general_condition;
        private string moisture_content;


        private string _standard;
        private string _approvedAgency;
        private string _description;

        public Standard() { }
        public Standard(string _standard, string _approvedAgency, string _description)
        {
            this._standard = _standard;
            this._approvedAgency = _approvedAgency;
            this._description = _description;
        }

        public Standard(string ProgagationType, string Class, string Crop, string InertMatter, double Purity, 
            double Other_Crop_Seed, double Total_Weed_seed, double GeneminationRate, double MoistureContent, double MoistureContentVapour,
            double isolation_distance, double other_crop_plants, double other_varities, double weed_plants, string plant_infected = null, string general_condition = null,
            string moisture_content = null)
        {
            this.ProgagationType = ProgagationType;
            this.Class = Class;
            this.Crop = Crop;
            this.InertMatter = InertMatter;
            this.Purity = Purity;
            this.Other_Crop_Seed = Other_Crop_Seed;
            this.Total_Weed_seed = Total_Weed_seed;
            this.GeneminationRate = GeneminationRate;
            this.MoistureContent = MoistureContent;
            this.MoistureContentVapour = MoistureContentVapour;
            this.isolation_distance = isolation_distance;
            this.other_crop_plants = other_crop_plants;
            this.other_varities = other_varities;
            this.weed_plants = weed_plants;
            this.plant_infected = plant_infected;
            this.general_condition = general_condition;
            this.moisture_content = moisture_content;
    }

        public static List<string> Combo(string Query)
        {
            List<string> x = new List<string>();
            standard_id = new List<string>();
            var dt = DB.GetInstance().Query(Query);
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    standard_id.Add(dt.Rows[i][0].ToString());
                    x.Add(dt.Rows[i][1].ToString());
                }
            return x;
        }

        public void AddUmbrellaStandard()
        {
            var v = new Dictionary<string, string>();
            v.Add("Standard_Name", _standard);
            v.Add("ApprovedBy", _approvedAgency);
            v.Add("Description", _description);
            bool added = DB.GetInstance().Insert("standard", v);
            if (added) MessageBox.Show("Standard has been added", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Standard failed to be added, please try again", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AddStandard()
        {
            int class_id = 0;
            int crop_id = 0;
            int propagation_type_id = 0;
            string[] Condition;

            Condition = new[] { "class_name", "=", Class };
            DB.GetInstance().Get("Class", Condition);
            if (DB.GetInstance().dt.Rows.Count > 0)
                class_id = Int32.Parse(DB.GetInstance().dt.Rows[0][0].ToString());
            else
            {
                MessageBox.Show("The Class you have choosen is not available","SPCMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Condition = new[] { "crop_name", "=", Crop };
            DB.GetInstance().Get("Crop", Condition);
            if(DB.GetInstance().dt.Rows.Count > 0)
                crop_id = Int32.Parse(DB.GetInstance().dt.Rows[0][0].ToString());
            else
            {
                MessageBox.Show("The Crop you have choosen is not available", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Condition = new[] { "type", "=", ProgagationType };
            DB.GetInstance().Get("standard_propagation_type", Condition);
            if(DB.GetInstance().dt.Rows.Count > 0)
                propagation_type_id = Int32.Parse(DB.GetInstance().dt.Rows[0][0].ToString());
            else
            {
                MessageBox.Show("The propagation type you have choosen is not available", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StandardName = Crop + " " + Class.Split(' ')[0];

            switch (ProgagationType)
            {
                case "Seed Propagation":
                    SeedPropagation(class_id, crop_id, propagation_type_id);
                    break;
                case "Tuber Propagation":
                    break;
                case "Grass Propagation":
                    break;
                default:
                    break;
            }

        }


        private void SeedPropagation(int class_id, int crop_id, int propagation_type_id)
        {
            var Values = new Dictionary<string, string>();

            Values.Add("class_id", class_id.ToString());
            Values.Add("crop_id", crop_id.ToString());
            Values.Add("propagation_type_id", propagation_type_id.ToString());
            Values.Add("standard_name", StandardName);
            Values.Add("pure_seed", Purity.ToString());
            Values.Add("inert_matter", InertMatter.ToString());
            Values.Add("other_crop_seed", Other_Crop_Seed.ToString());
            Values.Add("total_weed_seed", Total_Weed_seed.ToString());
            Values.Add("gemination_rate", GeneminationRate.ToString());
            Values.Add("moisture_content", MoistureContent.ToString());
            Values.Add("moisture_content_vapour", MoistureContentVapour.ToString());

            bool added = DB.GetInstance().Insert("propagation_seed_standard", Values);

            var Condition = new[] { "standard_name", "=", StandardName };
            DB.GetInstance().Get("propagation_seed_standard", Condition);
            seedStd_id = Int32.Parse(DB.GetInstance().dt.Rows[0][0].ToString());

            Values = new Dictionary<string, string>();

            Values.Add("seedStd_id", seedStd_id.ToString());
            Values.Add("isolation_distance", isolation_distance.ToString());
            Values.Add("other_crop_plants", other_crop_plants.ToString());
            Values.Add("other_varities", other_varities.ToString());
            Values.Add("weed_plants", weed_plants.ToString());
            Values.Add("plant_infected", plant_infected);
            Values.Add("general_condition", general_condition);
            Values.Add("moisture_content", moisture_content);

            added = DB.GetInstance().Insert("propagation_seed_field_standard", Values);

            if (added) MessageBox.Show("Standard for " + Crop + " under " + StandardName + " standard has been added", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Standard for " + Crop + " under " + StandardName + " standard failed to be added, please try again", "SPCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public override double RecommendedAction(int sowing_id)
        {
            this.sowing_id = sowing_id;
            return (Score = base.RecommendedAction(this.sowing_id));
        }

        protected override Dictionary<string, string> Issues()
        {
            MainIssues = new Dictionary<string, string>();
            return (MainIssues = base.Issues());
        }


        public string GenerateCertificationNumber(string sowing_id)
        {
            string crop = string.Empty;
            string category = string.Empty;
            string certificateNo = string.Empty;
            int num = 0;
            try
            {
                Random rand = new Random();
                string Query = "SELECT crop_name FROM crop, sowing_report WHERE crop.crop_id = sowing_report.crop_id AND sowing_id = "+sowing_id+"";
                var x = DB.GetInstance().Query(Query);
                crop = (x.Rows.Count > 0) ? x.Rows[0]["crop_name"].ToString() : "";

                Query = "SELECT class_name FROM class, sowing_report WHERE class.class_id = sowing_report.class_id AND sowing_id = "+sowing_id+"";
                x = DB.GetInstance().Query(Query);
                category = (x.Rows.Count > 0) ? x.Rows[0]["class_name"].ToString() : "";

                crop = (crop.Length > 3) ? crop.Substring(0, 3).ToUpper() : crop.ToUpper();
                category = category.Substring(0, 1).ToUpper();
                num = rand.Next(10000,90000);
                certificateNo = "BARS-" + num + "-" + crop + category;
                Query = "SELECT AUTO_INCREMENT FROM information_schema.`TABLES` WHERE TABLE_SCHEMA = \"sicms\" AND TABLE_NAME = \"certification_number\";";
                string id = (DB.GetInstance().Query(Query).Rows.Count > 0) ? DB.GetInstance().Query(Query).Rows[0][0].ToString() : "0";

                var z = new Dictionary<string, string>();
                z.Add("certification_no", certificateNo);
                DB.GetInstance().Insert("certification_number", z);
                z = new Dictionary<string, string>();
                z.Add("certification_id", id);
                z.Add("status", "Certified");
                DB.GetInstance().Update("sowing_report", "sowing_id", sowing_id, z);

                var t = DB.GetInstance().Query("SELECT * FROM sowing_report WHERE sowing_id = "+sowing_id+"");
                string msg = "CONGRATULATIONS! your seeds (" + crop + ": " + category + ") sown on "+t.Rows[0]["date_of_sowing"].ToString()+" have been certified, wait for further instructions from the" +
                    "department on how to proceed into processing. Your Certification Number is:" + certificateNo + "";

                z = new Dictionary<string, string>();
                z.Add("customer_id", t.Rows[0]["customer_id"].ToString());
                z.Add("content", msg);
                z.Add("date", DateFormatFixing(DateTime.Today.ToShortDateString()));
                DB.GetInstance().Insert("timeline", z);
            }
            catch { }
            return certificateNo;
        }

        public void Disqualify(string sowing_id)
        {
            string Query = "UPDATE sowing_report SET" +
                "status ='Disqualified'" +
                "WHERE sowing_id = " + sowing_id + ";";
            DB.GetInstance().Query(Query);
            var t = DB.GetInstance().Query("SELECT * FROM sowing_report WHERE sowing_id = " + sowing_id + "");
            string msg = "WE ARE SAD TO ANNOUNCE: That the seeds sown on " + t.Rows[0]["date_of_sowing"].ToString()+"." +
              "Contact the department for more information.";

            var z = new Dictionary<string, string>();
            z.Add("customer_id", t.Rows[0]["customer_id"].ToString());
            z.Add("customer_id", msg);
            z.Add("customer_id", DateFormatFixing(DateTime.Today.ToShortDateString()));
            DB.GetInstance().Insert("timeline", z);
        }

        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }
    }
}
