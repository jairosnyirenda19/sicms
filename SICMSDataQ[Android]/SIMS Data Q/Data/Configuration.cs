using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Config")]
    public class Configuration
    {
        [PrimaryKey, AutoIncrement, Column("config_id")]
        public int config_id { get; set; }
        public string address { get; set; }
        public int port { get; set; }

        public Configuration() { }
        public Configuration(string address, int port) 
        {
            this.address = address;
            this.port = port;
        }
        public Configuration(int config_id, string address, int port)
        {
            this.config_id = config_id;
            this.address = address;
            this.port = port;
        }

    }
}