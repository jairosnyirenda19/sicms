using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Models
{
    [Table("Client")]
    public class Client
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int id { get; set; }
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string full_name { get; private set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime joined { get; set; }

        private int image;

        public Client(){}

        public Client(int customer_id, string first_name, string last_name, string contact, string email, string address, DateTime joined) 
        {
            this.customer_id = customer_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.contact = contact;
            this.email = email;
            this.address = address;
            this.joined = joined;
        }

        public Client(int id, int customer_id, string first_name, string last_name, string contact, string email, string address, DateTime joined)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.contact = contact;
            this.email = email;
            this.address = address;
            this.joined = joined;
        }


        public Client(int customer_id, string name, string contact, int img, DateTime dt) 
        {
            this.customer_id = customer_id;
            full_name = name;
            this.contact = contact;
            image = img;
            joined = dt;
        }
        public int Image
        {
            get { return image; }
        }
    }
}