using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("Flowering")]
    public class Flowering
    {
        [PrimaryKey, AutoIncrement, Column("flowering_id")]
        public int flowering_id { get; set; }
        public int sowing_id { get; set; }
        public string isolation_maintain { get; set; }
        public string off_type_removal { get; set; }
        public string remarks { get; set; }
        public DateTime date { get; set; }
        public string inspector { get; set; }


        public Flowering(int flowering_id, int sowing_id, string isolation_maintain, string off_type_removal, string remarks, DateTime date, string inspector) 
        {
            this.flowering_id = flowering_id;
            this.sowing_id = sowing_id;
            this.isolation_maintain = isolation_maintain;
            this.off_type_removal = off_type_removal;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public Flowering(int sowing_id, string isolation_maintain, string off_type_removal, string remarks, DateTime date, string inspector)
        {
            this.sowing_id = sowing_id;
            this.isolation_maintain = isolation_maintain;
            this.off_type_removal = off_type_removal;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public Flowering()
        {

        }
    }
}