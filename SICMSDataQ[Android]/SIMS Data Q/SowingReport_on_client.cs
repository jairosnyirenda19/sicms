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
    [Activity(Label = "Available Sowing Report", Icon = "@drawable/icon")]
    public class SowingReport_on_client : Activity
    {
        private ListView listView;
        private CASowingReport_on_Client adapter;
        public static JavaList<SowingListItem> Listview;
        private TextView client_owner;

        public static int sowing_id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SowingReportsList);

            client_owner = FindViewById<TextView>(Resource.Id.nameTextSowingReportOwner);
            listView = FindViewById<ListView>(Resource.Id.SowingReport_on_Client_ListView);

            adapter = new CASowingReport_on_Client(this, GetListClients());
            listView.Adapter = adapter;

            client_owner.Text = "Sowing Report(s): " + Clients.clientsname;
            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            sowing_id = Listview[e.Position].Sowing_id_list;
            if (Sowing_Inspection_Options.Signature == "Sowing Report")
            {
                Intent sowing_Report_Page_One = new Intent(this, typeof(Sowing_Report_Page));
                this.StartActivity(sowing_Report_Page_One);
            }
            else if (Sowing_Inspection_Options.Signature == "Inspection")
            {
                Intent inspection = new Intent(this, typeof(Inspection));
                this.StartActivity(inspection);
            }
            
        }

        private JavaList<SowingListItem> GetListClients()
        {
            Listview = new JavaList<SowingListItem>();
            SowingListItem l;
            try
            {
                List<int> idx = new List<int>();
                string crop = "";
                string seedclass = "";
                var x = Sowing_Inspection_Options.sowingreport;

                for (int a = 0; a < x.Count; a++)
                    if (Clients.customer_id == x[a].customer_id)
                        idx.Add(a);

                if ((bool)(idx.Count > 0))
                {
                    for (int z = 0; z < idx.Count; z++)
                    {
                        for (int i = 0; i < Sowing_Inspection_Options.crop.Count; i++)
                            if (Sowing_Inspection_Options.crop[i].crop_id == x[idx[z]].crop_id)
                            {
                                crop = Sowing_Inspection_Options.crop[i].crop;
                                break;
                            }

                        for (int i = 0; i < Sowing_Inspection_Options.seedclass.Count; i++)
                            if (Sowing_Inspection_Options.seedclass[i].class_id == x[idx[z]].class_id)
                            {
                                seedclass = Sowing_Inspection_Options.seedclass[i].class_name + ": " + Sowing_Inspection_Options.seedclass[i].genetic_purity;
                                break;
                            }

                        l = new SowingListItem(idx[z], crop, seedclass, x[0].date_of_sowing, Resource.Drawable.icons8_paper_bag_with_seeds_48px);
                        Listview.Add(l);
                    }
                }
                else
                    Toast.MakeText(this, "No sowing reports available for this client. Try to SYNC", ToastLength.Short).Show();
            }
            catch { }
            return Listview;
        }
    }
}