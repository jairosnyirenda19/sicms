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
    [Activity(Label = "Pre Flowering Stage", Icon = "@drawable/icon")]
    public class Inspection_Phase_One : Activity
    {
        private TextView TextLinkSowingReport;
        private TextView TextClientNameInspection;
        private TextView TextCropNameInspection;
        private CheckBox ChkVerifySource;
        private CheckBox ChkVerifyAcreage;
        private CheckBox ChkVerifyUniformity;
        private CheckBox ChkVerifyProperRouging;
        private EditText TextIsolationDistance;
        private CheckBox ChkVerifyOff_typePlantFound;
        private CheckBox ChkVerifyIdentificationRemovalOfftype;
        private EditText TextInspectorRemarks;

        private Button btnSave;
        public static int sowing_id;
        private int idx_ins;
        private string Crop;
        private bool SetData;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Inspection_Phase_One);

            TextLinkSowingReport = FindViewById<TextView>(Resource.Id.TextLinkSowingReport);
            TextClientNameInspection = FindViewById<TextView>(Resource.Id.TextClientNameInspection);
            TextCropNameInspection = FindViewById<TextView>(Resource.Id.TextCropNameInspection);

            ChkVerifySource = FindViewById<CheckBox>(Resource.Id.ChkVerifySource);
            ChkVerifyAcreage = FindViewById<CheckBox>(Resource.Id.ChkVerifyAcreage);
            ChkVerifyUniformity = FindViewById<CheckBox>(Resource.Id.ChkVerifyUniformity);
            ChkVerifyProperRouging = FindViewById<CheckBox>(Resource.Id.ChkVerifyProperRouging);

            TextIsolationDistance = FindViewById<EditText>(Resource.Id.TextIsolationDistance);
            ChkVerifyOff_typePlantFound = FindViewById<CheckBox>(Resource.Id.ChkVerifyOff_typePlantFound);
            ChkVerifyIdentificationRemovalOfftype = FindViewById<CheckBox>(Resource.Id.ChkVerifyIdentificationRemovalOfftype);
            TextInspectorRemarks = FindViewById<EditText>(Resource.Id.TextInspectorRemarks);
            btnSave = FindViewById<Button>(Resource.Id.btnSavePhaseOneInspection);
            btnSave.Click += btnSave_Click;

            TextLinkSowingReport.Click += TextLinkSowingReport_Click;
            GetClientsInspectionData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TextIsolationDistance.Text == "")
                Toast.MakeText(this, "Please Enter the Isolation distance before saving", ToastLength.Short).Show();
            else if (TextInspectorRemarks.Text == "")
                Toast.MakeText(this, "Please Enter your remarks before saving", ToastLength.Short).Show();
            else
            {
                double isolation_distance = Convert.ToDouble(TextIsolationDistance.Text);
                string source = (ChkVerifySource.Checked) ? "Verified" : "Unverified";
                string acreage = (ChkVerifyAcreage.Checked) ? "Verified" : "Unverified";
                string uniformity = (ChkVerifyUniformity.Checked) ? "Verified" : "Unverified";
                string rouging = (ChkVerifyProperRouging.Checked) ? "Verified" : "Unverified";
                string off_types = (ChkVerifyOff_typePlantFound.Checked) ? "Verified" : "Unverified";
                string removal = ( ChkVerifyIdentificationRemovalOfftype.Checked) ? "Verified" : "Unverified";
                string remarks = TextInspectorRemarks.Text;
                DateTime date = DateTime.Now;
                var x = new PreFlowering(sowing_id, isolation_distance, source, acreage, uniformity, rouging, off_types, removal, remarks, date, Home.inspector);

                RunOnUiThread(async () =>
                {
                    var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Are you sure you want to save this Inspection ?", "Yes", "No");
                    if (isClosedApp)
                        SaveInspectionOne(x);
                });

            }
        }

        void TextLinkSowingReport_Click(object sender, EventArgs e)
        {
            Intent x = new Intent(this, typeof(Sowing_Report_Page));
            this.StartActivity(x);
        }

        void GetClientsInspectionData()  
        {
            var x = Sowing_Inspection_Options.sowingreport;
            var z = Sowing_Inspection_Options.crop;
            var y = Sowing_Inspection_Options.preflowing;

            int idx = SowingReport_on_client.sowing_id;
            string crop = string.Empty;
            SetData = false;
            sowing_id = x[idx].sowing_id;
            idx_ins = 0;
            for (int i = 0; i < z.Count; i++)
                if (x[idx].crop_id == z[i].crop_id)
                {
                    crop = z[i].crop;
                    break;
                }

            TextClientNameInspection.Text = Clients.clientsname;
            TextCropNameInspection.Text = (crop != string.Empty) ? crop : "N/A";

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
                    ChkVerifySource.Checked = (y[idx_ins].source == "Verified") ? true : false;
                    ChkVerifyAcreage.Checked = (y[idx_ins].acreage == "Verified") ? true : false;
                    ChkVerifyUniformity.Checked = (y[idx_ins].uniformity == "Verified") ? true : false;
                    ChkVerifyProperRouging.Checked = (y[idx_ins].rouging == "Verified") ? true : false;

                    TextIsolationDistance.Text = (y[idx_ins].isolation_distance != 0) ? y[idx_ins].isolation_distance.ToString() : "";

                    ChkVerifyOff_typePlantFound.Checked = (y[idx_ins].off_types == "Verified") ? true : false;
                    ChkVerifyIdentificationRemovalOfftype.Checked = (y[idx_ins].removal == "Verified") ? true : false;
                    TextInspectorRemarks.Text = (y[idx_ins].remarks != "") ? y[idx_ins].remarks : "";
                }
            }
        }

        async void SaveInspectionOne(PreFlowering x)
        {
            bool update = false;
            var container = x;
            var preflowering = await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(preflowering.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < preflowering.Count; i++)
                {
                    if ((bool)(x.sowing_id == preflowering[i].sowing_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new PreFlowering(preflowering[idx].preflowering_id, container.sowing_id, container.isolation_distance, container.source, container.acreage, container.uniformity, container.rouging, container.off_types, container.removal, container.remarks, container.date, Home.inspector);
                    await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await PreFloweringDatabaseController.PreFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            Toast.MakeText(this, "Pre-Flowering Inspection saved successfully", ToastLength.Short).Show();
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
    }
}