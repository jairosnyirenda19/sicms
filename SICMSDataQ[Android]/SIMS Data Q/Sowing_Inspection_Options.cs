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
    [Activity(Label = "Options", Icon = "@drawable/icon")]
    public class Sowing_Inspection_Options : Activity
    {
        private ListView listView;
        private CASowing_InspectionOptions adapter;
        private JavaList<ListMenuItems> listMenuItem;

        #region SOWING REPORTS ESSENTIALS

        public static List<SowingReport> sowingreport;
        public static List<Crop> crop;
        public static List<Variety> variety;
        public static List<SeedClass> seedclass;
        public static List<Payment> payment;
        public static List<PaymentMethod> paymentmethod;
        public static List<BankService> bank;
        public static List<MobileService> mobile;
        public static List<Certification> certification;

        #endregion

        #region INSPECTION ESSENTIALS

        public static List<PreFlowering> preflowing;
        public static List<Flowering> flowering;
        public static List<PostFlowering> postflowing;
        public static List<Harvest> harvest;

        #endregion

        public static string Signature;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ClientsOptions);

            listView = FindViewById<ListView>(Resource.Id.listviewClientsOptions);
            adapter = new CASowing_InspectionOptions(this, GetListMenuItems());
            listView.Adapter = adapter;

            listView.ItemClick += ListView_ItemClick;
        }

        private JavaList<ListMenuItems> GetListMenuItems()
        {
            @listMenuItem = new JavaList<ListMenuItems>();
            ListMenuItems l;

            l = new ListMenuItems("Sowing Report", Resource.Drawable.icons8_report_card_48px);
            @listMenuItem.Add(l);

            l = new ListMenuItems("Inspections", Resource.Drawable.icons8_inspection_48px);
            @listMenuItem.Add(l);

            return @listMenuItem;
        }

        private async void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            try
            {
                sowingreport = await SowingReportDatabaseController.SowingReportDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                seedclass = await SeedClassDatabaseController.seedClassDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                payment = await PaymentDatabaseController.PaymentDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                paymentmethod = await PaymentMethodDatabaseController.PaymentMethodDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                bank = await BankServiceDatabaseController.BankServiceDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                mobile = await MobileServiceDatabaseController.MobileServiceDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                crop = await CropDatabaseController.CropDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                variety = await VarietyDatabaseController.VarietyDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                certification = await CertificationDatabaseController.CertificationDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
                string item = @listMenuItem[e.Position].Name.ToString();
                if (item == "Sowing Report")
                {
                    Signature = "Sowing Report";
                    Intent sowingReport_on_client = new Intent(this, typeof(SowingReport_on_client));
                    this.StartActivity(sowingReport_on_client);
                }
                else if (item == "Inspections")
                {
                    Signature = "Inspection";
                    Intent sowingReport_on_client = new Intent(this, typeof(SowingReport_on_client));
                    this.StartActivity(sowingReport_on_client);
                }
            }
            catch { }
        }

    }
}