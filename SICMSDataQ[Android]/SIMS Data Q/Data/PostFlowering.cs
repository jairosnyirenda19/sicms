using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("PsotFlowering")]
    public class PostFlowering
    {
        [PrimaryKey, AutoIncrement, Column("post_flowering_id")]
        public int post_flowering_id { get; set; }
        public int sowing_id { get; set; }
        public string issues_taken_care { get; set; }
        public string remarks { get; set; }
        public DateTime date { get; set; }
        public string inspector { get; set; }

        public PostFlowering(int post_flowering_id, int sowing_id, string issues_taken_care, string remarks, DateTime date, string inspector) 
        {
            this.post_flowering_id = post_flowering_id;
            this.sowing_id = sowing_id;
            this.issues_taken_care = issues_taken_care;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }
        public PostFlowering(int sowing_id, string issues_taken_care, string remarks, DateTime date, string inspector)
        {
            this.sowing_id = sowing_id;
            this.issues_taken_care = issues_taken_care;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }
        public PostFlowering() { }
    }
}