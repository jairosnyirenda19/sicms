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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIMS_BARS.Models;

namespace SIMS_BARS.mCODE.mMySQL
{
    public class DataParserUpload
    {
        private Context context;
        private String urlAddress;

        public DataParserUpload(Context context, String urlAddress,String Configure) 
        {
            this.context = context;
            this.urlAddress = urlAddress;
            Config(Configure);
        }

        void Config(string Configure) 
        {
            switch(Configure)
            {
                case "Pre Flowering":
                    PreFlowering();
                    break;
                case "Flowering":
                     Flowering();
                    break;
                case "Post Flowering":
                    PostFlowering();
                    break;
                default:
                    Harvest();
                    break;
            }
        }

        async void PreFlowering()
        {
           var x = await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
           for (int i = 0; i < x.Count; i++) 
           {
               PreFlowering z = new PreFlowering()
               {
                    sowing_id = x[i].sowing_id,
                    isolation_distance = x[i].isolation_distance,
                    source = x[i].source,
                    acreage = x[i].acreage,
                    uniformity = x[i].uniformity,
                    rouging = x[i].rouging,
                    off_types = x[i].off_types,
                    removal = x[i].removal,
                    remarks = x[i].remarks,
                    date = x[i].date,
                    inspector = x[i].inspector
               };
               string JSON = JsonConvert.SerializeObject(z);
               new Uploader(context, urlAddress, JSON).Execute();
           }
        }

        async void Flowering()
        {
            var x = await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            for (int i = 0; i < x.Count; i++) 
            {
                Flowering z = new Flowering() {
                    sowing_id = x[i].sowing_id,
                    isolation_maintain = x[i].isolation_maintain,
                    off_type_removal = x[i].off_type_removal,
                    remarks = x[i].remarks,
                    date = x[i].date,
                    inspector = x[i].inspector
                };

                string JSON = JsonConvert.SerializeObject(z);
                new Uploader(context, urlAddress, JSON).Execute();
            }
        }

        async void PostFlowering()
        {
            var x = await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            for (int i = 0; i < x.Count; i++)
            {
                PostFlowering z = new PostFlowering()
                {
                    sowing_id = x[i].sowing_id,
                    issues_taken_care = x[i].issues_taken_care,
                    remarks = x[i].remarks,
                    date = x[i].date,
                    inspector = x[i].inspector
                };

                string JSON = JsonConvert.SerializeObject(z);
                new Uploader(context, urlAddress, JSON).Execute();
            }
        }

        async void Harvest()
        {
            var x = await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            for (int i = 0; i < x.Count; i++)
            {
                Harvest z = new Harvest()
                {
                    sowing_id = x[i].sowing_id,
                    maturity = x[i].maturity,
                    remarks = x[i].remarks,
                    date = x[i].date,
                    inspector = x[i].inspector
                };

                string JSON = JsonConvert.SerializeObject(z);
                new Uploader(context, urlAddress, JSON).Execute();
            }
        }
    }
}