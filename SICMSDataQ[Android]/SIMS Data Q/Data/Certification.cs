using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Certification")]
    public class Certification
    {
        [PrimaryKey, AutoIncrement, Column("id")]

        public int id { get; set; }
        public int certification_id { get; set; }
        public string certification_no { get; set; }

        public Certification(int id, int certification_id, string certification_no)
        {
            this.id = id;
            this.certification_id = certification_id;
            this.certification_no = certification_no;
        }

        public Certification(int certification_id, string certification_no) 
        {
            this.certification_id = certification_id;
            this.certification_no = certification_no;
        }
        public Certification() { }
    }
}