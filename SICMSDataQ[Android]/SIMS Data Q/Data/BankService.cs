using System;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("BankService")]
    public class BankService
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int bank_id { get; set; }
        public string bank_name { get; set; }
        public string account_number { get; set; }

        public BankService(int id, int bank_id, string bank_name, string account_number)
        {
            this.id = id;
            this.bank_id = bank_id;
            this.bank_name = bank_name;
            this.account_number = account_number;
        }

        public BankService(int bank_id, string bank_name, string account_number) 
        {
            this.bank_id = bank_id;
            this.bank_name = bank_name;
            this.account_number = account_number;
        }
        public BankService() { }
    }
}