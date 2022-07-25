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
using SIMS_BARS.Models;

namespace SIMS_BARS
{
    class DialogSettings : DialogFragment
    {
        private LinearLayout SettingMainView;
        private EditText TxtIpaddress;
        private EditText TxtPort;
        private Button BtnSave;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.Settings, container, false);

            SettingMainView = view.FindViewById<LinearLayout>(Resource.Id.LinearLayoutDialogSettings);
            TxtIpaddress = view.FindViewById<EditText>(Resource.Id.editIpaddress);
            TxtPort = view.FindViewById<EditText>(Resource.Id.editPort);
            BtnSave = view.FindViewById<Button>(Resource.Id.btnSaveSettings);

            SettingMainView.Click +=SettingMainView_Click;
            BtnSave.Click += BtnSave_Click;

            GetConfiguration();
            GetConfiguration();
            return view;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TxtIpaddress.Text == "")
            Toast.MakeText(this.Activity, "Please enter the address for remote server", ToastLength.Short).Show();
            else if (TxtPort.Text == "")
                Toast.MakeText(this.Activity, "Please enter the port for remote server", ToastLength.Short).Show();
            else
                SaveSettings(TxtIpaddress.Text, Convert.ToInt32(TxtPort.Text));
            
        }

        private void SettingMainView_Click(object sender, System.EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.Activity.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.Activity.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.DialogAnimation;
        }

        private async void SaveSettings(string i, int p)
        {
            var result = await ConfigurationurationDatabaseController.ConfigDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(result.Count > 0))
            {
                var x = new Configuration(result[0].config_id, i, p);
                await ConfigurationurationDatabaseController.ConfigDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
            }
            else
            {
                var z = new Configuration(i, p);
                await ConfigurationurationDatabaseController.ConfigDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(z);
            }
            Toast.MakeText(this.Activity, "Settings Saved Seccussfully", ToastLength.Short).Show();
        }

        private void GetConfiguration() 
        {
            Config config = new Config();
            TxtIpaddress.Text = config.ip_add;
            TxtPort.Text = config.port.ToString();
        }
    }
}