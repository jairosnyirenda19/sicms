using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("SowingReport")]
   public class SowingReport
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int sowing_id { get; set; }
        public int customer_id { get; set; }
        public int certification_id { get; set; }
        public int crop_id { get; set; }
        public int variety_id { get; set; }
        public int class_id { get; set; }
        public int payment_id { get; set; }
        public string seed_source { get; set; }
        public string tag_number { get; set; }
        public string purchase_bill_no { get; set; }
        public DateTime date_of_purchase { get; set; }
        public double quantity_per_acrea { get; set; }
        public double acreage { get; set; }
        public DateTime date_of_sowing { get; set; }
        public byte[] tagSrc { get; set; }
        public byte[] purchaseBill { get; set; }

        public SowingReport(int id, int sowing_id, int customer_id, int certification, int crop_id, int variety_id, int class_id, int payment_id, string seed_source, string tag_number,

   string purchase_bill_no, DateTime date_of_purchase, double quantity_per_acrea, double acreage, DateTime date_of_sowing, byte[] tagSrc, byte[] purchaseBill)
        {
            this.id = id;
            this.sowing_id = sowing_id;
            this.customer_id = customer_id;
            this.certification_id = certification_id;
            this.crop_id = crop_id;
            this.variety_id = variety_id;
            this.class_id = class_id;
            this.payment_id = payment_id;
            this.seed_source = seed_source;
            this.tag_number = tag_number;
            this.purchase_bill_no = purchase_bill_no;
            this.date_of_purchase = date_of_purchase;
            this.quantity_per_acrea = quantity_per_acrea;
            this.acreage = acreage;
            this.date_of_sowing = date_of_sowing;
            this.tagSrc = tagSrc;
            this.purchaseBill = purchaseBill;
        }

        public SowingReport(int sowing_id, int customer_id, int certification, int crop_id, int variety_id, int class_id, int payment_id, string seed_source, string tag_number,
            
           string purchase_bill_no, DateTime date_of_purchase, double quantity_per_acrea, double acreage, DateTime date_of_sowing, byte[] tagSrc,byte[] purchaseBill )
        {
            this.sowing_id = sowing_id;
            this.customer_id = customer_id;
            this.certification_id = certification_id;
            this.crop_id = crop_id;
            this.variety_id = variety_id;
            this.class_id = class_id;
            this.payment_id = payment_id;
            this.seed_source = seed_source;
            this.tag_number = tag_number;
            this.purchase_bill_no = purchase_bill_no;
            this.date_of_purchase = date_of_purchase;
            this.quantity_per_acrea = quantity_per_acrea;
            this.acreage = acreage;
            this.date_of_sowing = date_of_sowing;
            this.tagSrc = tagSrc;
            this.purchaseBill = purchaseBill;
        }

        public SowingReport(int sowing_id, string cropname, string seedclass, int Img) 
        {
            this.sowing_id_list = sowing_id;
            this.cropname = cropname;
            this.seedclass = seedclass;
            this.Img = Img;
        }

        public SowingReport()
        {

        }

        private int sowing_id_list;
        private string cropname;
        private string seedclass;
        private int Img;

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
    }
}