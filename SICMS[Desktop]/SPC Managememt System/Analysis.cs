using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Managememt_System
{
    public class Analysis
    {
        private string recommendationMsg;
        protected int sowing_id { get; set; }
        protected Dictionary<string, string> issues = new Dictionary<string, string>();

        public int TotalAnlysis;
        public Analysis(int sowing_id)
        {
            this.sowing_id = sowing_id;
        }

        public Analysis()
        {

        }

        public virtual double RecommendedAction(int sowing_id)
        {
            var Condition = new[] { "sowing_id", "=", sowing_id.ToString() };
            DB.GetInstance().Get("pre_flowering_inspection", Condition);
            var pre_flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id.ToString() };
            DB.GetInstance().Get("flowering_inspection", Condition);
            var flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id.ToString() };
            DB.GetInstance().Get("post_flowering_inspection", Condition);
            var post_flowering = DB.GetInstance().dt;

            Condition = new[] { "sowing_id", "=", sowing_id.ToString() };
            DB.GetInstance().Get("harvest_inspection", Condition);
            var harvest = DB.GetInstance().dt;

            if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0 && harvest.Rows.Count > 0)
            {
                issues = new Dictionary<string, string>();
                TotalAnlysis = 4;
                Issues();
                return (Pre_Flowering(pre_flowering) + Flowering(flowering) + Post_Flowering(post_flowering) + Harvest(harvest)) / 4;
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0 && post_flowering.Rows.Count > 0)
            {
                issues = new Dictionary<string, string>();
                TotalAnlysis = 3;
                Issues();
                return (Pre_Flowering(pre_flowering) + Flowering(flowering) + Post_Flowering(post_flowering)) / 3;
            }
            else if (pre_flowering.Rows.Count > 0 && flowering.Rows.Count > 0)
            {
                issues = new Dictionary<string, string>();
                TotalAnlysis = 2;
                Issues();
                return (Pre_Flowering(pre_flowering) + Flowering(flowering)) / 2;
            }
            else if (pre_flowering.Rows.Count > 0)
            {
                issues = new Dictionary<string, string>();
                TotalAnlysis = 1;
                Issues();
                return (Pre_Flowering(pre_flowering));
            }
            else
            {
                return 0;
            }
        }

        protected virtual Dictionary<string, string> Issues()
        {
            return issues;
        }


        private double Pre_Flowering(DataTable x)
        {
            double percent = (100 / 6);
            double total = 0;
            var Condition = new[] { "sowing_id", "=", sowing_id.ToString() };
            DB.GetInstance().Get("sowing_report", Condition);
            var z = DB.GetInstance().dt;
            int crop_id = Int32.Parse(z.Rows[0]["crop_id"].ToString());
            
            //ISOLATION DISTANCE CHECKING

            Condition = new[] { "crop_id", "=", crop_id.ToString() };
            DB.GetInstance().Get("propagation_seed_standard", Condition);
            var s = DB.GetInstance().dt;

            Condition = new[] { "crop_id", "=", crop_id.ToString() };
            DB.GetInstance().Get("propagation_grass_standard", Condition);
            var g = DB.GetInstance().dt;

            Condition = new[] { "crop_id", "=", crop_id.ToString() };
            DB.GetInstance().Get("propagation_tuber_standard", Condition);
            var t = DB.GetInstance().dt;

            if (s.Rows.Count > 0)
            {
                Condition = new[] { "seedStd_id", "=", s.Rows[0][0].ToString() };
                DB.GetInstance().Get("propagation_seed_field_standard", Condition);
                var sf = DB.GetInstance().dt;
                double actual = Convert.ToDouble(x.Rows[0]["isolation_distance"].ToString());
                double isolation = Convert.ToDouble(sf.Rows[0]["isolation_distance"].ToString());
                if (percentage(isolation, actual) >= 95)
                    total += percent;
            }
            else if (g.Rows.Count > 0)
            {
                Condition = new[] { "grassStd_id", "=", g.Rows[0][0].ToString() };
                DB.GetInstance().Get("", Condition);
                var sf = DB.GetInstance().dt;
                double isolation = Convert.ToDouble(sf.Rows[0]["isolation_distance"].ToString());
                if (percentage(isolation, Convert.ToDouble(x.Rows[0]["isolation_distance"].ToString())) >= 95)
                    total += percent;
            }
            else if (t.Rows.Count > 0)
            {
                Condition = new[] { "tuberStd_id", "=", t.Rows[0][0].ToString() };
                DB.GetInstance().Get("", Condition);
                var sf = DB.GetInstance().dt;
                double isolation = Convert.ToDouble(sf.Rows[0]["isolation_distance"].ToString());
                double actual_distance = Convert.ToDouble(x.Rows[0]["isolation_distance"].ToString());
                if (percentage(isolation, actual_distance) >= 95)
                    total += percent;
            }

            if (total == 0)
            {
                recommendationMsg = "This field does not adhere to the isolation distance for this crop as this is fatal" +
                    " to seed production. The recommended action is to NOT GIVE THIS FIELD A CERTIFICATION NUMBER and should" +
                    " be DISQUALIFIED with immediate effect!";
                issues.Add("Isolation Distance",recommendationMsg);
            }


            if (x.Rows[0]["source"].ToString() == "Verified")
            {
                total += percent;
            }
            else
            {
                recommendationMsg = "The farmers source of seeds has not been verified as this is fatal" +
                    " to seed production. The recommended action is to NOT GIVE THIS FIELD A CERTIFICATION NUMBER and should" +
                    " be DISQUALIFIED with immediate effect!";
                issues.Add("Source of Seeds", recommendationMsg);
            }

            if (x.Rows[0]["acreage"].ToString() == "Verified")
            {
                total += percent;
            }
            else
            {
                recommendationMsg = "The acreage of the field has not been verified. The recommended action is depends on the" +
                    " Inspector Officer Remarks";
                issues.Add("Acreage", recommendationMsg);
            }

            if (x.Rows[0]["rouging"].ToString() == "Verified")
            {
                total += percent;
            }
            else
            {
                recommendationMsg = "The proper rouging of the field has not been verified. The recommended action is depends on the" +
                    " Inspector Officer Remarks";
                issues.Add("Rouging", recommendationMsg);
            }

            if (x.Rows[0]["off_type"].ToString() == "Verified")
            {
                if (x.Rows[0]["removal"].ToString()== "Verified")
                {
                    total += percent;
                    recommendationMsg = "Off-Type plants where found and they have been removed. The recommended action is depends on the" +
                        " Inspector Officer Remarks";
                    issues.Add("Off-Type found and Removed", recommendationMsg);
                }
                else
                {
                    recommendationMsg = "Removal of Off-Type plants on the field has not been verified. The recommended action is depends on the" +
                        " Inspector Officer Remarks";
                    issues.Add("Off-Type found and Removed", recommendationMsg);
                }
            }
            else
            {
                total += (percent * 2);
            }

            return total;
        }

        private double Flowering(DataTable x)
        {
            double percent = (100 / 2);
            double total = 0;

            if (x.Rows[0]["isolation_maintain"].ToString() == "Verified")
            {
                total += percent;
            }
            else
            {
                recommendationMsg = "The Isolation distance has not been maintained for this field. The recommended action is depends on the"  +
                    " to seed production. The recommended action is to NOT GIVE THIS FIELD A CERTIFICATION NUMBER and should" +
                    " be DISQUALIFIED with immediate effect!";
                issues.Add("Isolation Maintainance", recommendationMsg);
            }

            if (x.Rows[0]["off_type_removal"].ToString() == "Verified")
            {
                total += percent;
            }
            else
            {
                recommendationMsg = "Removal of Off-Type plants on the field has not been verified for the second time. The recommended action is depends on the" +
                    " Inspector Officer Remarks";
                issues.Add("Off-Type Removal", recommendationMsg);
            }

            return total;
        }

        private double Post_Flowering(DataTable x)
        {           
            if (x.Rows[0]["issues_taken_care"].ToString() == "Verified")
            {
                return 100;
            }
            else
            {
                recommendationMsg = "Issues from previous inspections have not been taken care off. Such situations Recommended action " +
                    "is to DISQUALIFY the client with immediate effect";
                issues.Add("Issues Taken Care", recommendationMsg);
            }
            return 0;
        }

        private double Harvest(DataTable x)
        {
            if (x.Rows[0]["maturity"].ToString() == "Verified")
            {
                return 100;
            }
            else
            {
                recommendationMsg = "Harvesting is not yet verified. Perharps wait a while longer";
                issues.Add("Maturity", recommendationMsg);
            }
            return 0;
        }

        private double percentage(double a, double b)
        {
            double p = (a - b <= 0) ? 100 : (a - b);
            if ((bool)(p != 100))
            {
                if (p > 0)                
                    return ((b / a) * 100);                                    
            }
            return p;
        }
    }
}
