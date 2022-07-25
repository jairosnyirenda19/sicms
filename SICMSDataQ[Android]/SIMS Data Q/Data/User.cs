using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace SIMS_BARS.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Username { get; set; }

        public User() { }
        public User(string Username) 
        {
            this.Username = Username;

        }
    }
}