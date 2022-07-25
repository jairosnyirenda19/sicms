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

namespace SIMS_BARS
{
    public class ListClientView
    {
        private int customer_id;
        private string first_name;
        private string last_name;
        private string contact;
        private string email;
        private string address;
        private DateTime joined;
        private string name;
        private string crop;
        private string district;
        private int image;

        public ListClientView(string name, string crop, string district, int image) 
        {
            this.name = name;
            this.crop = crop;
            this.district = district;
            this.image = image;
        }

        public string Name 
        {
            get { return name;}
        }
        public string Crop
        {
            get { return crop; }
        }
        public string District
        {
            get { return district; }
        }
        public int Image 
        {
            get { return image; }
        }

    }
}