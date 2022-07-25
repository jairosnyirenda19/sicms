using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Crop")]
    public class Crop
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int crop_id { get; set; }
        public string crop { get; set; }

        public Crop(int id, int crop_id, string crop)
        {
            this.id = id;
            this.crop_id = crop_id;
            this.crop = crop;
        }

        public Crop(int crop_id, string crop) 
        {
            this.crop_id = crop_id;
            this.crop = crop;
        }
        public Crop() { }


    }
}