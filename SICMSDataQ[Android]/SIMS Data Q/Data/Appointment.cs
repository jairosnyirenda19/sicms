using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS.Data
{
    [Table("Appointment")]
    public class Appointment
    {
        [PrimaryKey, AutoIncrement, Column("id")]

        public int id { get; set; }
        public int appointment_id { get; set; }
        public int customer_id { get; set; }
        public int inspector_id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date_of_appointment { get; set; }

        public Appointment(int id, int appointment_id, int customer_id, int inspector_id, string title, string content, DateTime date_of_appointment)
        {
            this.id = id;
            this.appointment_id = appointment_id;
            this.customer_id = customer_id;
            this.inspector_id = inspector_id;
            this.title = title;
            this.content = content;
            this.date_of_appointment = date_of_appointment;
        }

        public Appointment(int appointment_id, int customer_id, int inspector_id, string title, string content, DateTime date_of_appointment) 
        {
            this.appointment_id = appointment_id;
            this.customer_id = customer_id;
            this.inspector_id = inspector_id;
            this.title = title;
            this.content = content;
            this.date_of_appointment = date_of_appointment;
        }
        public Appointment() { }
    }
}