using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMS_BARS.Models;
using SIMS_BARS.Data;

namespace SIMS_BARS
{
    public class Config
    {
        public string ip_add { get; set; }
        public int port { get; set; }
        public Config() 
        {
            GetConfiguration();
        }

        public async void GetConfiguration()
        {
            var x = await ConfigurationurationDatabaseController.ConfigDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if (x.Count > 0)
            {
                ip_add = x[0].address;
                port = x[0].port;
            }
        }

    }
}