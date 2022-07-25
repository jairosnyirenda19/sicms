using System;

namespace SIMS_BARS
{
    public class SowingListItem 
    {
        private int sowing_id_list;
        private string cropname;
        private string seedclass;
        private int Img;
        private DateTime date;
        public SowingListItem (int sowing_id, string cropname, string seedclass, DateTime date,int Img) 
        {
            this.sowing_id_list = sowing_id;
            this.cropname = cropname;
            this.seedclass = seedclass;
            this.Img = Img;
            this.date = date;
        }

        public string Cropname 
        {
            get { return cropname; }
            set { cropname = value; }
        }

        public string Seedclass
        {
            get { return seedclass; }
            set { seedclass = value; }
        }

        public int Sowing_id_list
        {
            get { return sowing_id_list; }
            set { sowing_id_list = value; }
        }

        public int Image
        {
            get { return Img; }
            set { Img = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}