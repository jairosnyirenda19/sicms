using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("PreFlowering")]
    public class PreFlowering
    {
        [PrimaryKey, AutoIncrement, Column("preflowering_id")]
        public int preflowering_id { get; set; }
        public int sowing_id { get; set; }
        public double isolation_distance { get; set; }
        public string source { get; set; }
        public string acreage { get; set; }
        public string uniformity { get; set; }
        public string rouging { get; set; }
        public string off_types { get; set; }
        public string removal { get; set; }
        public string remarks { get; set; }
        public DateTime date { get; set; }
        public string inspector { get; set; }
        public PreFlowering(int preflowering_id, int sowing_id, double isolation_distance, string source, string acreage, string uniformity, string rouging, string off_types, string removal, string remarks, DateTime date, string inspector)
        {
            this.preflowering_id = preflowering_id;
            this.sowing_id = sowing_id;
            this.isolation_distance = isolation_distance;
            this.source = source;
            this.acreage = acreage;
            this.uniformity = uniformity;
            this.rouging = rouging;
            this.off_types = off_types;
            this.removal = removal;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public PreFlowering(int sowing_id, double isolation_distance, string source, string acreage, string uniformity, string rouging, string off_types, string removal, string remarks, DateTime date, string inspector) 
        {
            this.sowing_id = sowing_id;
            this.isolation_distance = isolation_distance;
            this.source = source;
            this.acreage = acreage;
            this.uniformity = uniformity;
            this.rouging = rouging;
            this.off_types = off_types;
            this.removal = removal;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public PreFlowering() { }
    }
}