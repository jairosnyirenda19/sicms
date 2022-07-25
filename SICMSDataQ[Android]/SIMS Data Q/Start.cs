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
    [Activity(Label = "Start", Icon = "@drawable/icon")]
    public class Start : Activity
    {
        private ListView @listView;
        private CA @adapter;
        private JavaList<ListMenuItems> @listMenuItem;
        public static List<SIMS_BARS.Models.Client> client = new List<Models.Client>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Start);

            @listView = FindViewById<ListView>(Resource.Id.listview);
            @adapter = new CA(this, GetListMenuItems());
            @listView.Adapter = @adapter;
            @listView.ItemClick += ListView_ItemClick;
        }

        private async void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string item = @listMenuItem[e.Position].Name.ToString();
            if (item == "All Clients")
            {
                client = await SIMS_BARS.Models.ClientDatabaseController.ClientDatabaseInstance(SIMS_BARS.Models.ConnectionString.GetConnection()).GetItemsAsync();
                while (client.Count < 0) 
                {
                    client = await SIMS_BARS.Models.ClientDatabaseController.ClientDatabaseInstance(SIMS_BARS.Models.ConnectionString.GetConnection()).GetItemsAsync();
                }
                Intent IntentClient = new Intent(this, typeof(Clients));
                this.StartActivity(IntentClient);

            }
        }

        private JavaList<ListMenuItems> GetListMenuItems() 
        {
            @listMenuItem = new JavaList<ListMenuItems>();
            ListMenuItems l;

            l = new ListMenuItems("All Clients", Resource.Drawable.icons8_Farmer_48px);
            @listMenuItem.Add(l);

            l = new ListMenuItems("Appointments", Resource.Drawable.icons8_Planner_48px);
            @listMenuItem.Add(l);

            return @listMenuItem;
        }
    }
}