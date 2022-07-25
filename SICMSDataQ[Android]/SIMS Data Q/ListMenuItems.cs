using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS_BARS
{
    class ListMenuItems
    {
        private string name;
        private int image;

        public ListMenuItems(string name, int image) 
        {
            this.name = name;
            this.image = image;
        }

        public string Name 
        {
            get { return name;}
        }

        public int Image 
        {
            get { return image; }
        }
    }
}