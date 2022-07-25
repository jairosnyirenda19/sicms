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
using System.IO;


namespace SIMS_BARS.mCODE.mMySQL
{
    class Downloader : AsyncTask
    {
        private Context context;
        private ProgressDialog progress;
        private String urlAddress;
        private String Configure;

        public Downloader(Context context, String urlAddress, String Configure) 
        {
            this.context = context;
            this.urlAddress = urlAddress;
            this.Configure = Configure;
        }
        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            progress = new ProgressDialog(context);
            progress.SetTitle("SYNCING");
            progress.SetMessage("Getting Data...");
            progress.Show();
        }
        protected override Object DoInBackground(params Object[] @params)
        {
            return this.Download();
        }

        protected override void OnPostExecute(Object result)
        {
            base.OnPostExecute(result);
            progress.Dismiss();
            if (result.ToString().StartsWith("Error"))
                Toast.MakeText(context, "SYNC Unsecceful, " + result.ToString(), ToastLength.Short).Show();
            else
                new DataParser(context,result.ToString() , Configure).Execute();
        }

        #region DOWNLOAD DATA

        private Object Download() 
        {
            var conn = Connection.Connect(urlAddress);
            if(conn.ToString().StartsWith("Error"))
                return conn.ToString(); ;

            try 
            {
                Java.Net.HttpURLConnection xConn = (Java.Net.HttpURLConnection)conn;
                if (xConn.ResponseCode == Java.Net.HttpStatus.Ok)
                {
                    var stream = new BufferedStream(xConn.InputStream);
                    var bufferedReader = new Java.IO.BufferedReader(new Java.IO.InputStreamReader(stream));
                    var JSON = new Java.Lang.StringBuffer();
                    String line = null;
                    
                    while ((line = bufferedReader.ReadLine()) != null)
                        JSON.Append(line + "\n");
                    
                    bufferedReader.Close();
                    stream.Close();
                    return JSON;
                }
                else 
                {
                    return "Error " + xConn.ResponseCode.ToString() + " : " + xConn.ResponseMessage;
                }
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