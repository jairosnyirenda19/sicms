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
    [Activity(Label = "Inspections", Icon = "@drawable/icon")]
    public class Inspection : Activity
    {
        private ListView listView;
        private CAInspections adapter;
        private JavaList<ListMenuItems> listMenuItem;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.InspectionsListView);

            listView = FindViewById<ListView>(Resource.Id.listviewInspections);
            adapter = new CAInspections(this, GetListMenuItems());
            listView.Adapter = adapter;
            listView.ItemClick += ListView_ItemClick;
        }

        private JavaList<ListMenuItems> GetListMenuItems()
        {
            @listMenuItem = new JavaList<ListMenuItems>();
            ListMenuItems l;

            l = new ListMenuItems("Pre Flowering Stage", Resource.Drawable.icons8_1_circle_c_48px);
            @listMenuItem.Add(l);

            l = new ListMenuItems("Flowering Stage", Resource.Drawable.icons8_2_circle_c_48px);
            @listMenuItem.Add(l);

            l = new ListMenuItems("Post Flowering (Pre Harvest) Stage", Resource.Drawable.icons8_3_circle_c_48px);
            @listMenuItem.Add(l);

            l = new ListMenuItems("Harvest Stage", Resource.Drawable.icons8_4_circle_c_48px);
            @listMenuItem.Add(l);
            return @listMenuItem;
        }

        private async void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Sowing_Inspection_Options.preflowing = await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            Sowing_Inspection_Options.postflowing = await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            Sowing_Inspection_Options.flowering = await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            Sowing_Inspection_Options.harvest = await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            string item = @listMenuItem[e.Position].Name.ToString();
            if (item == "Pre Flowering Stage")
            {
                Intent IntentClient = new Intent(this, typeof(Inspection_Phase_One));
                this.StartActivity(IntentClient);
            }
            else if (item == "Flowering Stage")
            {
                Intent IntentClient = new Intent(this, typeof(Inspection_Phase_Two));
                this.StartActivity(IntentClient);
            }
            else if (item == "Post Flowering (Pre Harvest) Stage")
            {
                Intent IntentClient = new Intent(this, typeof(Inspection_Phase_Three));
                this.StartActivity(IntentClient);
            }
            else 
            {
                Intent IntentClient = new Intent(this, typeof(Inspection_Phase_Four));
                this.StartActivity(IntentClient);
            }
        }
    }
}