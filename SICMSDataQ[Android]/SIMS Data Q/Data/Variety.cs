using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Variety")]
    public class Variety
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int variety_id { get; set; }
        public int crop_id { get; set; }
        public string variety { get; set; }


        public Variety(int id, int variety_id, int crop_id, string variety)
        {
            this.id = id;
            this.variety_id = variety_id;
            this.crop_id = crop_id;
            this.variety = variety;
        }

        public Variety(int variety_id, int crop_id, string variety)
        {
            this.variety_id = variety_id;
            this.crop_id = crop_id;
            this.variety = variety;
        }

        public Variety() 
        {

        }
    }
}