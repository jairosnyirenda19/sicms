using System;
using Java.Net;
using Java.IO;
using System.Net.Http;
using System.Text;
using System.Net;
using Android.Widget;
using Android.Content;


namespace SIMS_BARS.mCODE.mMySQL
{
    class Connection
    {
        public static string return_connection_upload = string.Empty;
        public static Java.Lang.Object Connect(String urlAddress) 
        {
            try
            {
                URL url = new URL(urlAddress);
                HttpURLConnection conn = (HttpURLConnection)url.OpenConnection();

                conn.RequestMethod = "GET";
                conn.ConnectTimeout = 20000;
                conn.ReadTimeout = 20000;
                conn.DoInput = true;
                return conn;
            }
            catch (MalformedURLException e)
            {
                System.Console.WriteLine(e.Message);
                return "Error " + e.Message;
            }
            catch (IOException e) 
            {
                System.Console.WriteLine(e.Message);
                return "Error " + e.Message;
            }
            
        }


        public static void ConnectUpload(string url, string JSON) 
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

                myRequest.Method = "POST";

                string postData = JSON;

                byte[] pdata = Encoding.UTF8.GetBytes(postData);

                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentLength = pdata.Length;

                System.IO.Stream myStream = myRequest.GetRequestStream();
                myStream.Write(pdata, 0, pdata.Length);


                // Get response from your php file.
                WebResponse myResponse = myRequest.GetResponse();

                System.IO.Stream responseStream = myResponse.GetResponseStream();

                System.IO.StreamReader streamReader = new System.IO.StreamReader(responseStream);

                // Pass the response to a string and display it in a toast message.
                string result = streamReader.ReadToEnd();

                result = return_connection_upload;
                // Close your streams.
                streamReader.Close();
                responseStream.Close();
                myResponse.Close();
                myStream.Close();
            }
            catch (WebException ex)
            {
                string _exception = ex.ToString();
                System.Console.WriteLine("--->" + _exception);
            }
        } 
    }
}