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
    [Activity(Label = "Post Flowering Stage", Icon = "@drawable/icon")]
    public class Inspection_Phase_Three : Activity
    {
        private TextView TextLinkSowingReportPhaseThree;
        private TextView TextClientNameInspectionPhaseThree;
        private TextView TextCropNameInspectionPhaseThree;
        private CheckBox ChkVerifyPreviousInspectionIssuesTakenCareOff;
        private EditText TextInspectorRemarksPhaseThree;
        private Button BtnSavePhaseThreeInspection;

        private int sowing_id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Inspection_Phase_Three);

            TextLinkSowingReportPhaseThree = FindViewById<TextView>(Resource.Id.TextLinkSowingReportPhaseThree);
            TextClientNameInspectionPhaseThree = FindViewById<TextView>(Resource.Id.TextClientNameInspectionPhaseThree);
            TextCropNameInspectionPhaseThree = FindViewById<TextView>(Resource.Id.TextCropNameInspectionPhaseThree);
            ChkVerifyPreviousInspectionIssuesTakenCareOff = FindViewById<CheckBox>(Resource.Id.ChkVerifyPreviousInspectionIssuesTakenCareOff);
            TextInspectorRemarksPhaseThree = FindViewById<EditText>(Resource.Id.TextInspectorRemarksPhaseThree);
            BtnSavePhaseThreeInspection = FindViewById<Button>(Resource.Id.btnSavePhaseThreeInspection);

            TextLinkSowingReportPhaseThree.Click += TextLinkSowingReportPhaseThree_Click;
            BtnSavePhaseThreeInspection.Click += BtnSavePhaseThreeInspection_Click;
            GetClientsInspectionData();
        }

        void BtnSavePhaseThreeInspection_Click(object sender, EventArgs e)
        {
            if (TextLinkSowingReportPhaseThree.Text == "")
                Toast.MakeText(this, "Please Enter your remarks before saving", ToastLength.Short).Show();
            else
            {
                int sowing_id = Inspection_Phase_One.sowing_id;
                string isuess_taken_care = (ChkVerifyPreviousInspectionIssuesTakenCareOff.Checked) ? "Verified" : "Unverified";
                string remarks = (TextInspectorRemarksPhaseThree.Text != "") ? TextInspectorRemarksPhaseThree.Text : "";
                DateTime date = DateTime.Now;
                var x = new PostFlowering(sowing_id, isuess_taken_care, remarks, date, Home.inspector);
                RunOnUiThread(async () =>
                {
                    var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Are you sure you want to save this Inspection ?", "Yes", "No");
                    if (isClosedApp)
                        SaveInspectionThree(x);
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
        
        void TextLinkSowingReportPhaseThree_Click(object sender, EventArgs e)
        {
            Intent x = new Intent(this, typeof(Sowing_Report_Page));
            this.StartActivity(x);
        }

        async void SaveInspectionThree(PostFlowering x)
        {
            bool update = false;
            var container = x;
            var postflowering = await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(postflowering.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < postflowering.Count; i++)
                {
                    if ((bool)(x.sowing_id == postflowering[i].sowing_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new PostFlowering(postflowering[idx].post_flowering_id, container.sowing_id, container.issues_taken_care, container.remarks, container.date, Home.inspector);
                    await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await PostFloweringDatabaseController.PostFloweringDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            Toast.MakeText(this, "Post Flowering Inspection saved successfully", ToastLength.Short).Show();
        }

        void GetClientsInspectionData()
        {
            var x = Sowing_Inspection_Options.sowingreport;
            var z = Sowing_Inspection_Options.crop;
            var y = Sowing_Inspection_Options.postflowing;
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

            TextClientNameInspectionPhaseThree.Text = Clients.clientsname;
            TextCropNameInspectionPhaseThree.Text = (crop != string.Empty) ? crop : "N/A";

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
                    ChkVerifyPreviousInspectionIssuesTakenCareOff.Checked = (y[idx_ins].issues_taken_care == "Verified") ? true : false;
                    TextInspectorRemarksPhaseThree.Text = (y[idx_ins].remarks != "") ? y[idx_ins].remarks : "";
                }
            }
        }
    }
}