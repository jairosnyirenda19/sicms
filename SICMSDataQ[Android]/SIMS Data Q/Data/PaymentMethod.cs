using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int method_id { get; set; }
        public string method { get; set; }

        public PaymentMethod(int id, int method_id, string method)
        {
            this.id = id;
            this.method_id = method_id;
            this.method = method;
        }

        public PaymentMethod(int method_id, string method)
        {
            this.method_id = method_id;
            this.method = method;
        }

        public PaymentMethod() 
        {
        }

    }
}