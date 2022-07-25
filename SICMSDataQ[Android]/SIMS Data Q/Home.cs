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
using System.ComponentModel;
using System.Threading.Tasks;

using SIMS_BARS.Models;
using SIMS_BARS.mCODE.mMySQL;

namespace SIMS_BARS
{
    [Activity(Label = "SIMS Data Q", Icon = "@drawable/icon")]
    public class Home : Activity
    {
        public static string add { get; set; }
        public static int port { get; set; }

        private LinearLayout HomeMainView;
        private Button BtnStart;

        private Button BtnIncomplete;
        private Button BtnSync;
        private Button BtnLogout;
        private TextView LblUsername;

        public static string inspector;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            HomeMainView = FindViewById<LinearLayout>(Resource.Id.linearlayout);
            BtnStart = FindViewById<Button>(Resource.Id.btnstart);
            BtnSync = FindViewById<Button>(Resource.Id.btnsync);
            BtnLogout = FindViewById<Button>(Resource.Id.btnlogout);
            LblUsername = FindViewById<TextView>(Resource.Id.lblusername);


            BtnStart.Click += BtnStart_Click;
            BtnSync.Click += BtnSync_Click;
            BtnLogout.Click += BtnLogout_Click;

            GetConfiguration();
            GetUser();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Start));
            this.StartActivity(intent);
        }

        private void BtnSaved_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Inspection));
            this.StartActivity(intent);
        }


        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Forget();
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            RunOnUiThread(() =>
            {
                GetConfiguration();
                SYNC_SERVER sync = new SYNC_SERVER(add, port);
                new Downloader(this, sync.SYNC_CLIENTS, "Clients").Execute();
                new Downloader(this, sync.SYNC_CROP, "Crop").Execute();
                new Downloader(this, sync.SYNC_VARIETY, "Variety").Execute();
                new Downloader(this, sync.SYNC_CLASS, "Seed Class").Execute();
                new Downloader(this, sync.SYNC_BANK_SERVICE, "Bank Service").Execute();
                new Downloader(this, sync.SYNC_MOBILE_SERVICE, "Mobile Service").Execute();
                new Downloader(this, sync.SYNC_PAYMENT_METHOD, "Payment Method").Execute();
                new Downloader(this, sync.SYNC_PAYMENT_DETAILS, "Payment").Execute();
                new Downloader(this, sync.SYNC_CERTIFICATION, "Certification").Execute();
                new Downloader(this, sync.SYNC_SOWING_REPORT, "Sowing Report").Execute();
                new Downloader(this, sync.SYNC_APPOINTMENTS, "Appointments").Execute();

                new DataParserUpload(this, sync.SYNC_UPLOAD_PRE_FLOWERING,"Pre Flowering");
                new DataParserUpload(this, sync.SYNC_UPLOAD_FLOWERING, "Flowering");
                new DataParserUpload(this, sync.SYNC_UPLOAD_POST_FLOWERING, "Post Flowering");
                new DataParserUpload(this, sync.SYNC_UPLOAD_HARVEST, "Harvest");
            });

        }

        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
        }

        private async void GetUser() 
        {
            var x = await UserDatabaseController.UserDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if (x.Count > 0) 
            {
               LblUsername.Text = "Logged in: " + x[0].Username;
               inspector = x[0].Username;
            }
        }
        private async void Forget()
        {
            var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Do you want to log out ?", "Yes", "No");
            if (isClosedApp)
            {
                string Query = "DELETE FROM User";
                await UserDatabaseController.UserDatabaseInstance(ConnectionString.GetConnection()).GetItemsNotDoneAsync(Query);
                Intent intent = new Intent(this, typeof(SignIn));
                this.StartActivity(intent);
            }
        }

        public async void GetConfiguration()
        {
            var x = await ConfigurationurationDatabaseController.ConfigDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if (x.Count > 0)
            {
                add = x[0].address;
                port = x[0].port;
            }
        }

        public override void OnBackPressed()
        {
            RunOnUiThread(async () => {
                var isClosedApp = await AlertAsync(this, "SIMS Data Q", "Do you want to exit this application ?", "Yes", "No");
                if (isClosedApp) 
                {
                    FinishAffinity();
                    Java.Lang.JavaSystem.Exit(0);
                    
                }
            });
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