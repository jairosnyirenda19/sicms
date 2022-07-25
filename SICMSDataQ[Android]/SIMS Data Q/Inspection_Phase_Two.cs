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
    [Activity(Label = "Flowering Stage", Icon = "@drawable/icon")]
    public class Inspection_Phase_Two : Activity
    {
        private TextView TextLinkSowingReportPhaseTwo;
        private TextView TextClientNameInspectionPhaseTwo;
        private TextView TextCropNameInspectionPhaseTwo;
        private CheckBox ChkVerifyMaintanceOfIsolationDistance;
        private CheckBox ChkVerifyOff_TypeRemovalProperRouging;
        private EditText TextInspectorRemarksPhaseTwo;
        private Button BtnSavePhaseTwoInspection;

        private int sowing_id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Inspection_Phase_Two);

            TextLinkSowingReportPhaseTwo = FindViewById<TextView>(Resource.Id.TextLinkSowingReportPhaseTwo);
            TextClientNameInspectionPhaseTwo = FindViewById<TextView>(Resource.Id.TextClientNameInspectionPhaseTwo);
            TextCropNameInspectionPhaseTwo = FindViewById<TextView>(Resource.Id.TextCropNameInspectionPhaseTwo);
            ChkVerifyMaintanceOfIsolationDistance = FindViewById<CheckBox>(Resource.Id.ChkVerifyMaintanceOfIsolationDistance);
            ChkVerifyOff_TypeRemovalProperRouging = FindViewById<CheckBox>(Resource.Id.ChkVerifyOff_TypeRemovalProperRouging);
            TextInspectorRemarksPhaseTwo = FindViewById<EditText>(Resource.Id.TextInspectorRemarksPhaseTwo);
            BtnSavePhaseTwoInspection = FindViewById<Button>(Resource.Id.btnSavePhaseTwoInspection);

            TextLinkSowingReportPhaseTwo.Click += TextLinkSowingReportPhaseTwo_Click;
            BtnSavePhaseTwoInspection.Click += BtnSavePhaseTwoInspection_Click;
            GetClientsInspectionData();
        }

        void BtnSavePhaseTwoInspection_Click(object sender, EventArgs e)
        {
            if (TextLinkSowingReportPhaseTwo.Text == "")
               Toast.MakeText(this, "Please Enter your remarks before saving", ToastLength.Short).Show();
            else
            {
                int sowing_id = Inspection_Phase_One.sowing_id;
                string isolation_distance_maintain = (ChkVerifyMaintanceOfIsolationDistance.Checked) ? "Verified" : "Unverified";
                string off_type_removal = (ChkVerifyOff_TypeRemovalProperRouging.Checked) ? "Verified" : "Unverified";
                string remarks = (TextInspectorRemarksPhaseTwo.Text != "") ? TextInspectorRemarksPhaseTwo.Text : "";
                DateTime date = DateTime.Now;
                var x = new Flowering(sowing_id, isolation_distance_maintain, off_type_removal, remarks, date, Home.inspector);
                RunOnUiThread(async () =>
                {
                    var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Are you sure you want to save this Inspection ?", "Yes", "No");
                    if (isClosedApp)
                        SaveInspectionTwo(x);
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
        
        void TextLinkSowingReportPhaseTwo_Click(object sender, EventArgs e)
        {
            Intent x = new Intent(this, typeof(Sowing_Report_Page));
            this.StartActivity(x);
        }

        async void SaveInspectionTwo(Flowering x) 
        {
            bool update = false;
            var container = x;
            var flowering = await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(flowering.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < flowering.Count; i++)
                {
                    if ((bool)(x.sowing_id == flowering[i].sowing_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new Flowering(flowering[idx].flowering_id, container.sowing_id, container.isolation_maintain, container.off_type_removal, container.remarks, container.date, Home.inspector);
                    await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await FloweringDatabaseController.FloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            Toast.MakeText(this, "Flowering Inspection saved successfully", ToastLength.Short).Show();    
        }

        void GetClientsInspectionData()
        {
            var x = Sowing_Inspection_Options.sowingreport;
            var z = Sowing_Inspection_Options.crop;
            var y = Sowing_Inspection_Options.flowering;

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

           TextClientNameInspectionPhaseTwo.Text = Clients.clientsname;
           TextCropNameInspectionPhaseTwo.Text = (crop != string.Empty) ? crop : "N/A";

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
                    ChkVerifyMaintanceOfIsolationDistance.Checked = (y[idx_ins].isolation_maintain == "Verified") ? true : false;
                    ChkVerifyOff_TypeRemovalProperRouging.Checked = (y[idx_ins].off_type_removal == "Verified") ? true : false;
                    TextInspectorRemarksPhaseTwo.Text = (y[idx_ins].remarks != "") ? y[idx_ins].remarks : "";
                }
            }
        }
    }
}