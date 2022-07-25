using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Payment")]
    public class Payment
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int payment_id { get; set; }
        public int method_id { get; set; }
        public int customer_id { get; set; }
        public int mobile_id { get; set; }
        public int bank_id { get; set; }
        public string transaction_id { get; set; }
        public byte[] bank_deposit_slip { get; set; }

        public Payment(int id, int payment_id, int method_id, int customer_id, int mobile_id, int bank_id, string transaction_id, byte[] bank_deposit_slip)
        {
            this.id = id;
            this.payment_id = payment_id;
            this.method_id = method_id;
            this.customer_id = customer_id;
            this.mobile_id = mobile_id;
            this.bank_id = bank_id;
            this.transaction_id = transaction_id;
            this.bank_deposit_slip = bank_deposit_slip;
        }

        public Payment(int payment_id, int method_id, int customer_id, int mobile_id, int bank_id, string transaction_id, byte[] bank_deposit_slip) 
        {
            this.payment_id = payment_id;
            this.method_id = method_id;
            this.customer_id = customer_id;
            this.mobile_id = mobile_id;
            this.bank_id = bank_id;
            this.transaction_id = transaction_id;
            this.bank_deposit_slip = bank_deposit_slip;
        }
        public Payment() { }
    }
}