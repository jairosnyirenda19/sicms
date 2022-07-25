using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("Harvest")]
    public class Harvest
    {
        [PrimaryKey, AutoIncrement, Column("harvest_id")]
        public int harvest_id { get; set; }
        public int sowing_id { get; set; }
        public string maturity { get; set; }
        public string remarks { get; set; }
        public DateTime date { get; set; }
        public string inspector { get; set; }

        public Harvest(int harvest_id, int sowing_id, string maturity, string remarks, DateTime date, string inspector) 
        {
            this.harvest_id = harvest_id;
            this.sowing_id = sowing_id;
            this.maturity = maturity;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public Harvest(int sowing_id, string maturity, string remarks, DateTime date, string inspector)
        {
            this.sowing_id = sowing_id;
            this.maturity = maturity;
            this.remarks = remarks;
            this.date = date;
            this.inspector = inspector;
        }

        public Harvest()
        {
        }
    }
}