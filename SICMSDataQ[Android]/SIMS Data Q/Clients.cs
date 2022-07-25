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
using SIMS_BARS.Models;

namespace SIMS_BARS
{
    [Activity(Label = "Clients", Icon = "@drawable/icon")]
    public class Clients : Activity
    {
        private ListView @listView;
        private CAClients @adapter;
        private JavaList<Client> @listClientView;

        public static int customer_id;
        public static string clientsname;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Clients);

            @listView = FindViewById<ListView>(Resource.Id.AllClientsListView);
            @adapter = new CAClients(this, GetListClients());
            @listView.Adapter = @adapter;

            @listView.ItemClick += ListView_ItemClick;

        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            customer_id = @listClientView[e.Position].customer_id;
            clientsname = @listClientView[e.Position].full_name;
            if (customer_id > 0)
            {
                Intent IntentClient = new Intent(this, typeof(Sowing_Inspection_Options));
                this.StartActivity(IntentClient);
            }

        }

        private JavaList<Client> GetListClients()
        {
            @listClientView = new JavaList<Client>();
            Client l;
            var x = Start.client;
            if ((bool)(x.Count > 0))
            {
                for (int i = 0; i < x.Count; i++)
                {
                    l = new Client(x[i].customer_id, x[i].first_name + " " + x[i].last_name, x[i].contact ,Resource.Drawable.icons8_Male_User_48px, x[i].joined);
                    @listClientView.Add(l);
                }
            }else
                Toast.MakeText(this, "No data for clients available at the moment. Try to SYNC", ToastLength.Short).Show();

            return @listClientView;
        }
    }
}