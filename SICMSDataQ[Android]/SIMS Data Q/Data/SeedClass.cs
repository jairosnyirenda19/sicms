using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("SeedClass")]
    public class SeedClass
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int class_id { get; set; }
        public string class_name { get; set; }
        public string genetic_purity { get; set; }

        public SeedClass(int id, int class_id, string class_name, string genetic_purity)
        {
            this.id = id;
            this.class_id = class_id;
            this.class_name = class_name;
            this.genetic_purity = genetic_purity;
        }

        public SeedClass(int class_id, string class_name, string genetic_purity) 
        {
            this.class_id = class_id;
            this.class_name = class_name;
            this.genetic_purity = genetic_purity;
        }

        public SeedClass() 
        {

        }
    }
}