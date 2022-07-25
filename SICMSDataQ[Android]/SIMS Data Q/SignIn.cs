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
using Android.Views.InputMethods;
using System.Net;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using SIMS_BARS.Models;
using System.Timers;

namespace SIMS_BARS
{
    [Activity(Label = "SIMS", MainLauncher = true, Icon = "@drawable/icon")]
    public class SignIn : Activity
    {
        public static string add { get; set; }
        public static int port { get; set; }

        private LinearLayout loginMainView;
        private Button btnSignIn;
        private Button btnSettings;
        private EditText txtUsername;
        private EditText txtPassword;
        private CheckBox chkRemember;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SignIn);

            GetConfiguration();
            Remember();

            loginMainView = FindViewById<LinearLayout>(Resource.Id.linearLayout);
            txtUsername = FindViewById<EditText>(Resource.Id.editUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.editPassword);            
            btnSignIn = FindViewById<Button>(Resource.Id.btnSignin);
            chkRemember = FindViewById<CheckBox>(Resource.Id.checkBox1);
            btnSettings = FindViewById<Button>(Resource.Id.btnSettings);

            btnSignIn.Click += btnSignIn_Click;
            loginMainView.Click += loginMainView_Click;

            btnSettings.Click += (object sender, EventArgs e) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSettings dialogSettings = new DialogSettings();
                dialogSettings.Show(transaction, "");
            };
        }


        void btnSignIn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" && txtPassword.Text == "")
                    Toast.MakeText(this, "Please provide username and password", ToastLength.Short).Show();
                else if (txtUsername.Text == "")
                    Toast.MakeText(this, "Please provide a username", ToastLength.Short).Show();
                else if (txtPassword.Text == "")
                    Toast.MakeText(this, "Please provide a password", ToastLength.Short).Show();
                else
                {
                    GetConfiguration();
                    GetConfiguration();
                    SYNC_SERVER sync = new SYNC_SERVER(add, port);
                    WebClient client = new WebClient();
                    Uri uri = new Uri(sync.SYNC_LOGIN);
                    NameValueCollection parameters = new NameValueCollection();
                    string remember = (chkRemember.Checked == true) ? "Remember" : "Forget";
                    parameters.Add("Username", txtUsername.Text);
                    parameters.Add("Password", txtPassword.Text);
                    parameters.Add("Remember", remember);
                    client.UploadValuesCompleted += client_UploadValuesCompleted;
                    client.UploadValuesAsync(uri, parameters);
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }
        }

        private void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            try
            {
                RunOnUiThread(() =>
                {
                    string count = Encoding.UTF8.GetString(e.Result);
                    int totalCount = 0;
                    int.TryParse(count, out totalCount);
                    bool login = (totalCount > 0) ? true : false;
                    if (login)
                    {
                        if (chkRemember.Checked == true)
                            SaveUser();
                        Intent intent = new Intent(this, typeof(Home));
                        this.StartActivity(intent);
                    }
                    else
                        Toast.MakeText(this, "Log in failed. Please try again", ToastLength.Short).Show();

                });
            }
            catch
            {
                Toast.MakeText(this, "Check your network and Try again", ToastLength.Short).Show();
            }

        }

        void loginMainView_Click(object sender, System.EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }
        
        #region CUSTOM METHODS

        //Remember Me Functionality
        private async void SaveUser() 
        {
            var i = new User(txtUsername.Text);
            int result = await UserDatabaseController.UserDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(i);
        }

        private async void Remember()
        {
            var result = await UserDatabaseController.UserDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if (result.Count > 0) 
            {
                Intent intent = new Intent(this, typeof(Home));
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

        #endregion
    }
}

