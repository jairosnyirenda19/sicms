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
using System.Threading.Tasks;

namespace SIMS_BARS
{
    [Activity(Label = "Harvest Stage", Icon = "@drawable/icon")]
    public class Inspection_Phase_Four : Activity
    {
        private TextView TextLinkSowingReportPhaseFour;
        private TextView TextClientNameInspectionPhaseFour;
        private TextView TextCropNameInspectionPhaseFour;
        private CheckBox ChkVerifyMaturity;
        private EditText TextInspectorRemarksPhaseFour;
        private Button BtnSavePhaseFourInspection;

        private int sowing_id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Inspection_Phase_Four);

            TextLinkSowingReportPhaseFour = FindViewById<TextView>(Resource.Id.TextLinkSowingReportPhaseFour);
            TextClientNameInspectionPhaseFour = FindViewById<TextView>(Resource.Id.TextClientNameInspectionPhaseFour);
            TextCropNameInspectionPhaseFour = FindViewById<TextView>(Resource.Id.TextCropNameInspectionPhaseFour);
            ChkVerifyMaturity = FindViewById<CheckBox>(Resource.Id.ChkVerifyMaturity);
            TextInspectorRemarksPhaseFour = FindViewById<EditText>(Resource.Id.TextInspectorRemarksPhaseFour);
            BtnSavePhaseFourInspection = FindViewById<Button>(Resource.Id.btnSavePhaseFourInspection);

            TextLinkSowingReportPhaseFour.Click += TextLinkSowingReportPhaseFour_Click;
            BtnSavePhaseFourInspection.Click += BtnSavePhaseFourInspection_Click;

            GetClientsInspectionData();
        }

        void BtnSavePhaseFourInspection_Click(object sender, EventArgs e)
        {

            if (TextLinkSowingReportPhaseFour.Text == "")
                Toast.MakeText(this, "Please Enter your remarks before saving", ToastLength.Short).Show();
            else
            {
                int sowing_id = Inspection_Phase_One.sowing_id;
                string maturity = (ChkVerifyMaturity.Checked) ? "Verified" : "Unverified";
                string remarks = (TextInspectorRemarksPhaseFour.Text != "") ? TextInspectorRemarksPhaseFour.Text : "";
                DateTime date = DateTime.Now;
                var x = new Harvest(sowing_id, maturity, remarks, date, Home.inspector);
                RunOnUiThread(async () =>
                {
                    var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Are you sure you want to save this Inspection ?", "Yes", "No");
                    if (isClosedApp)
                        SaveInspectionFour(x);
                });
            }
        }

        public Task<bool> AlertAsync(Context context, string title, string message, string positiveButton, string negativeButton)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (var db = new AlertDialog.Builder(context))
            {
                db.SetTitle(title);
                db.SetMessage(message);
                db.SetPositiveButton(positiveButton, (sender, args) => { tcs.TrySetResult(true); });
                db.SetNegativeButton(negativeButton, (sender, args) => { tcs.TrySetResult(false); });
                db.Show();
            }
            return tcs.Task;
        }
        void TextLinkSowingReportPhaseFour_Click(object sender, EventArgs e)
        {
            Intent x = new Intent(this, typeof(Sowing_Report_Page));
            this.StartActivity(x);
        }

        async void SaveInspectionFour(Harvest x)
        {
            bool update = false;
            var container = x;
            var harvest = await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(harvest.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < harvest.Count; i++)
                {
                    if ((bool)(x.sowing_id == harvest[i].sowing_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new Harvest(harvest[idx].harvest_id, container.sowing_id, container.maturity, container.remarks, container.date, Home.inspector);
                    await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await HarvestDatabaseController.HarvestDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            Toast.MakeText(this, "Harvest Inspection saved successfully", ToastLength.Short).Show();
        }

        void GetClientsInspectionData()
        {
            var x = Sowing_Inspection_Options.sowingreport;
            var z = Sowing_Inspection_Options.crop;
            var y = Sowing_Inspection_Options.harvest;
            bool SetData = false;
            int idx = SowingReport_on_client.sowing_id;
            string crop = string.Empty;
            sowing_id = x[idx].sowing_id;
            int idx_ins = 0;
            for (int i = 0; i < z.Count; i++)
                if (x[idx].crop_id == z[i].crop_id)
                {
                    crop = z[i].crop;
                    break;
                }

            TextClientNameInspectionPhaseFour.Text = Clients.clientsname;
            TextCropNameInspectionPhaseFour.Text = (crop != string.Empty) ? crop : "N/A";

            if (y.Count > 0)
            {
                for (int i = 0; i < y.Count; i++)
                    if (y[i].sowing_id == sowing_id)
                    {
                        idx_ins = i;
                        SetData = true;
                        break;
                    }

                if (SetData)
                {
                    ChkVerifyMaturity.Checked = (y[idx_ins].maturity == "Verified") ? true : false;
                    TextInspectorRemarksPhaseFour.Text = (y[idx_ins].remarks != "") ? y[idx_ins].remarks : "";
                }
            }
        }
    }
}