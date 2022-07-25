using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("MobileService")]
    public class MobileService
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int mobile_id { get; set; }
        public string mobile_name { get; set; }
        public string contact { get; set; }

        public MobileService(int id, int mobile_id, string mobile_name, string contact)
        {
            this.id = id;
            this.mobile_id = mobile_id;
            this.mobile_name = mobile_name;
            this.contact = contact;
        }

        public MobileService(int mobile_id, string mobile_name, string contact)
        {
            this.mobile_id = mobile_id;
            this.mobile_name = mobile_name;
            this.contact = contact;
        }

        public MobileService() 
        {
        }
    }
}