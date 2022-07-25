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
using Object = Java.Lang.Object;



namespace SIMS_BARS.mCODE.mMySQL
{
    public class Uploader : AsyncTask
    {
        private Context context;
        private ProgressDialog progress;
        private String urlAddress;
        private String JSON;

        public Uploader(Context context, String urlAddress, String JSON) 
        {
            this.context = context;
            this.urlAddress = urlAddress;
            this.JSON = JSON;
        }
        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            progress = new ProgressDialog(context);
            progress.SetTitle("SYNCING");
            progress.SetMessage("Sending Data...");
            progress.Show();
        }
        protected override Object DoInBackground(params Object[] @params)
        {
            return this.Upload();
        }

        protected override void OnPostExecute(Object result)
        {
            base.OnPostExecute(result);
            progress.Dismiss();
            if (result.ToString().StartsWith("Error"))
                Toast.MakeText(context, "SYNC Unsecceful, " + result.ToString(), ToastLength.Short).Show();
            else { }
        }

        #region UPLOAD DATA

        private Object Upload()
        {
            try 
            {
                Connection.ConnectUpload(urlAddress, JSON);
                return Connection.return_connection_upload;
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
                return "Error " + e.Message;
            }
        }
        #endregion
    }
}