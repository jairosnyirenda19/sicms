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
using Org.Json;
using SIMS_BARS.Models;
using SIMS_BARS.Data;
using Android.Graphics;
using System.Net;
using System.IO;


namespace SIMS_BARS.mCODE.mMySQL
{
    class DataParser : AsyncTask
    {
        private Context context;
        private ProgressDialog progress;
        private String JSON;
        private String Configure;

        public static string add { get; set; }
        public static int port { get; set; }
        public DataParser(Context context, String JSON, String Configure) 
        {
            this.context = context;
            this.JSON = JSON;
            this.Configure = Configure;
        }
        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            progress = new ProgressDialog(context);
            progress.SetTitle("SYNCING");
            progress.SetMessage("Parsing Data "+Configure+"...");
            progress.Show();
        }
        protected override Object DoInBackground(params Object[] @params)
        {
            return Parse(Configure);
        }

        protected override void OnPostExecute(Object result)
        {
            base.OnPostExecute(result);
            progress.Dismiss();
            if ((bool)result) 
            {

            }
            else
                Toast.MakeText(context, "SYNC Unseccessful, Please try again later", ToastLength.Short).Show();
        }

        #region PARSE DATA INTO TABLES

        private Boolean Parse(string config) 
        {
            try
            {
            if (IsValidJson(JSON))
            {
                var JArray = new JSONArray(JSON);
                JSONObject JObject;

                switch (config)
                {
                    case "Clients":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new Client(Int32.Parse(JObject.GetString("customer_id")), JObject.GetString("Firstname"), JObject.GetString("Lastname"), JObject.GetString("Contact"), JObject.GetString("Email"), JObject.GetString("Address"), Convert.ToDateTime(JObject.GetString("Joined")));
                            GetClients(x);
                        }
                        break;
                    case "Crop":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new Crop(Int32.Parse(JObject.GetString("crop_id")), JObject.GetString("crop_name"));
                            GetCrops(x);
                        }
                        break;
                    case "Variety":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new Variety(Int32.Parse(JObject.GetString("variety_id")), Int32.Parse(JObject.GetString("crop_id")), JObject.GetString("variety_name"));
                            GetVariety(x);
                        }
                        break;
                    case "Seed Class":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new SeedClass(Int32.Parse(JObject.GetString("class_id")), JObject.GetString("class_name"), JObject.GetString("genetic_purity"));
                            GetClass(x);
                        }
                        break;
                    case "Bank Service":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new BankService(Int32.Parse(JObject.GetString("bank_id")), JObject.GetString("bank_name"), JObject.GetString("account_number"));
                            GetBankService(x);
                        }
                        break;
                    case "Mobile Service":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new MobileService(Int32.Parse(JObject.GetString("service_id")), JObject.GetString("service_name"), JObject.GetString("contact"));
                            GetMobileService(x);
                        }
                        break;
                    case "Payment Method":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new PaymentMethod(Int32.Parse(JObject.GetString("method_id")), JObject.GetString("Method"));
                            GetPaymentMethod(x);
                        }
                        break;
                    case "Payment":
                        GetConfiguration();
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);

                            int payment_id = (JObject.GetString("payment_id") != "") ? Int32.Parse(JObject.GetString("payment_id")) : 0;
                            int method_id = (JObject.GetString("method_id") != "") ? Int32.Parse(JObject.GetString("method_id")) : 0;
                            int customer_id = (JObject.GetString("customer_id") != "") ? Int32.Parse(JObject.GetString("customer_id")) : 0;
                            int service_id = 0;
                            int bank_id = 0;
                            string transaction_id = "";
                            byte[] bank_deposit_slip = null;

                            if (JObject.GetString("service_id") != "null")
                                if (JObject.GetString("service_id") != "")
                                    service_id = Int32.Parse(JObject.GetString("service_id"));

                            if (JObject.GetString("bank_id") != "null")
                                if (JObject.GetString("bank_id") != "")
                                    bank_id = Int32.Parse(JObject.GetString("bank_id"));

                            if (JObject.GetString("transaction_id") != "null")
                                if (JObject.GetString("transaction_id") != "")
                                    transaction_id = JObject.GetString("transaction_id");

                            if (JObject.GetString("bank_deposit_slip") != "null")
                                if (JObject.GetString("bank_deposit_slip") != "")
                                    bank_deposit_slip = GetBytesFromBitmap(GetImageBitmapFromUrl(JObject.GetString("bank_deposit_slip")));

                            var x = new Payment(payment_id, method_id, customer_id, service_id, bank_id, transaction_id, bank_deposit_slip);
                            GetPayment(x);
                        }
                        break;
                    case "Certification":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new Certification(Int32.Parse(JObject.GetString("certification_id")), JObject.GetString("certification_no"));
                            GetCertification(x);
                        }
                        break;
                    case "Sowing Report":
                        GetConfiguration();
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);

                            int sowing_id = Int32.Parse(JObject.GetString("sowing_id"));
                            int customer_id = Int32.Parse(JObject.GetString("customer_id"));
                            int certification_id = 0;
                            int crop_id = Int32.Parse(JObject.GetString("crop_id"));
                            int variety_id = Int32.Parse(JObject.GetString("variety_id"));
                            int class_id = Int32.Parse(JObject.GetString("class_id"));
                            int payment_id = Int32.Parse(JObject.GetString("payment_id"));
                            string seed_source = JObject.GetString("seed_source");
                            string tag_number = JObject.GetString("tag_number");
                            string purchase_bill_no = JObject.GetString("purchase_bill_no");
                            DateTime date_of_purchase = Convert.ToDateTime(JObject.GetString("date_of_purchase"));
                            double quantity_per_acrea = Convert.ToDouble(JObject.GetString("quantity_per_acrea"));
                            double acreage = Convert.ToDouble(JObject.GetString("acreage"));
                            DateTime date_of_sowing = Convert.ToDateTime(JObject.GetString("date_of_sowing"));
                            byte[] tagSrc = GetBytesFromBitmap(GetImageBitmapFromUrl(JObject.GetString("tagSrc")));
                            byte[] purchaseBill = GetBytesFromBitmap(GetImageBitmapFromUrl(JObject.GetString("purchaseBill")));

                            if (JObject.GetString("certification_id") != "null")
                                if (JObject.GetString("certification_id") != "")
                                    certification_id = Int32.Parse(JObject.GetString("certification_id"));

                            var x = new SowingReport(sowing_id, customer_id, certification_id, crop_id, variety_id, class_id, payment_id, seed_source, tag_number, purchase_bill_no, date_of_purchase, quantity_per_acrea, acreage, date_of_sowing, tagSrc, purchaseBill);
                            GetSowingReport(x);
                        }
                        break;
                    case "Appointments":
                        for (int i = 0; i < JArray.Length(); i++)
                        {
                            JObject = JArray.GetJSONObject(i);
                            var x = new Appointment(Int32.Parse(JObject.GetString("oppointment_id")), Int32.Parse(JObject.GetString("customer_id")), Int32.Parse(JObject.GetString("inspector_id")), JObject.GetString("title"), JObject.GetString("content"), Convert.ToDateTime(JObject.GetString("date_of_appointment")));
                            GetAppointment(x);
                        }
                        break;
                    default:
                        break;
                }

                return true;
            }
            else
                return false;
            }
            catch(JSONException e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        private bool IsValidJson(string json)
        {
            try 
            {
                var JArray = new JSONArray(json);
                return true;
            }catch
            {
                return false;
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
        
        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;
            try
            {
                GetConfiguration();
                GetConfiguration();
                string path = "http://" + add + ":" + port + "/SPCMS/" + url;
                

                using (var webClient = new WebClient())
                {
                    var imageBytes = webClient.DownloadData(path);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    }
                }
            }catch(Exception ex)
            {
               // Toast.MakeText(context, ex.Message, ToastLength.Short).Show();
            }

            return imageBitmap;
        }
        
        public byte[] GetBytesFromBitmap(Bitmap bitmap)
        {
            byte[] bitmapData = null;
            try
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();                
            }
            catch
            {
                //Toast.MakeText(context, ex.Message, ToastLength.Short).Show();
            }
            return bitmapData;
        }

        private async void GetClients(Client x) 
        {
            bool update = false;
            var container = x;
            var client = await ClientDatabaseController.ClientDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(client.Count > 0))
            {
                int idx = 0;
                for (int a = 0; a < client.Count; a++) 
                {
                    if ((bool)(x.customer_id == client[a].customer_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }

                if (update)
                {
                    x = new Client(client[idx].id, container.customer_id, container.first_name, container.last_name, container.contact, container.email, container.address, container.joined);
                    await ClientDatabaseController.ClientDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else 
                    await ClientDatabaseController.ClientDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                
            }
            else
                await ClientDatabaseController.ClientDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }

        private async void GetCrops(Crop x)
        {
            bool update = false;
            var container = x;
            var crop = await CropDatabaseController.CropDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(crop.Count > 0)) 
            {
                int idx = 0;
                for (int a = 0; a < crop.Count; a++)
                {
                    if ((bool)(x.crop_id == crop[a].crop_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }

                if (update)
                {
                    x = new Crop(crop[idx].id, container.crop_id, container.crop);
                    await CropDatabaseController.CropDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await CropDatabaseController.CropDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                
            }
            else
                await CropDatabaseController.CropDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }

        private async void GetVariety(Variety x)
        {
            bool update = false;
            var container = x;
            var variety = await VarietyDatabaseController.VarietyDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(variety.Count > 0))
            {
                int idx = 0;
                for (int a = 0; a < variety.Count; a++)
                {
                    if ((bool)(x.variety_id == variety[a].crop_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }

                if (update)
                {
                    x = new Variety(variety[idx].id, container.variety_id, container.crop_id,container.variety);
                    await VarietyDatabaseController.VarietyDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await VarietyDatabaseController.VarietyDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                            
            }
            else
                await VarietyDatabaseController.VarietyDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }

        private async void GetClass(SeedClass x)
        {
            bool update = false;
            var container = x;
            var _class = await SeedClassDatabaseController.seedClassDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(_class.Count > 0))
            {
                int idx = 0;
                for (int a = 0; a < _class.Count; a++)
                {
                    if ((bool)(x.class_id == _class[a].class_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }
                if (update)
                {                   
                    x = new SeedClass(_class[idx].id,  container.class_id,  container.class_name,  container.genetic_purity);
                    await SeedClassDatabaseController.seedClassDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await SeedClassDatabaseController.seedClassDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);               
            }
            else
                await SeedClassDatabaseController.seedClassDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }

        private async void GetBankService(BankService x)
        {
            bool update = false;
            var container = x;
            var bank_service = await BankServiceDatabaseController.BankServiceDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(bank_service.Count > 0))
            {
                int idx = 0;
                for (int a = 0; a < bank_service.Count; a++)
                {
                    if ((bool)(x.bank_id == bank_service[a].bank_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }
                if (update)
                {                    
                    x = new BankService(bank_service[idx].id, container.bank_id, container.bank_name, container.account_number);
                    await BankServiceDatabaseController.BankServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await BankServiceDatabaseController.BankServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                
            }
            else
                await BankServiceDatabaseController.BankServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }

        private async void GetMobileService(MobileService x)
        {
            bool update = false;
            var container = x;
            var mobile_service = await MobileServiceDatabaseController.MobileServiceDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(mobile_service.Count > 0))
            {
                int idx = 0;
                for (int a = 0; a < mobile_service.Count; a++)
                {
                    if ((bool)(x.mobile_id == mobile_service[a].mobile_id))
                    {
                        update = true;
                        idx = a;
                        break;
                    }
                }
                if (update)
                {
                    x = new MobileService(mobile_service[idx].id, container.mobile_id, container.mobile_name, container.contact);
                    await MobileServiceDatabaseController.MobileServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await MobileServiceDatabaseController.MobileServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await MobileServiceDatabaseController.MobileServiceDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
        }
  
        private async void GetPaymentMethod(PaymentMethod x)
        {
            bool update = false;
            var container = x;
            var payment_method = await PaymentMethodDatabaseController.PaymentMethodDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(payment_method.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < payment_method.Count; i++)
                {
                    if ((bool)(x.method_id== payment_method[i].method_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new PaymentMethod(payment_method[idx].id, container.method_id, container.method);
                    await PaymentMethodDatabaseController.PaymentMethodDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await PaymentMethodDatabaseController.PaymentMethodDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await PaymentMethodDatabaseController.PaymentMethodDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);       
        }

        private async void GetPayment(Payment x)
        {
            bool update = false;
            var container = x;
            var payment = await PaymentDatabaseController.PaymentDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(payment.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < payment.Count; i++)
                {
                    if ((bool)(x.payment_id == payment[i].payment_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new Payment(payment[idx].id, container.payment_id, container.method_id, container.customer_id, container.mobile_id, container.bank_id, container.transaction_id, container.bank_deposit_slip);
                    await PaymentDatabaseController.PaymentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await PaymentDatabaseController.PaymentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await PaymentDatabaseController.PaymentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);               
        }

        private async void GetCertification(Certification x)
        {
            bool update = false;
            var container = x;
            var certification = await CertificationDatabaseController.CertificationDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(certification.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < certification.Count; i++)
                {
                    if ((bool)(x.certification_id == certification[i].certification_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }

                if (update)
                {
                    x = new Certification(certification[idx].id, container.certification_id, container.certification_no);
                    await CertificationDatabaseController.CertificationDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await CertificationDatabaseController.CertificationDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
                
            }
            else
                await CertificationDatabaseController.CertificationDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                       
        }

        private async void GetSowingReport(SowingReport x)
        {
            bool update = false;
            var container = x;
            var sowingreport = await SowingReportDatabaseController.SowingReportDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(sowingreport.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < sowingreport.Count; i++)
                {
                    if ((bool)(x.sowing_id == sowingreport[i].sowing_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }
                if (update)
                {
                    x = new SowingReport(sowingreport[idx].id, container.sowing_id, container.customer_id, container.certification_id, container.crop_id, container.variety_id, container.class_id, container.payment_id, container.seed_source, container.tag_number, container.purchase_bill_no, container.date_of_purchase, container.quantity_per_acrea, container.acreage, container.date_of_sowing, container.tagSrc, container.purchaseBill);
                    await SowingReportDatabaseController.SowingReportDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(x);
                }
                else
                    await SowingReportDatabaseController.SowingReportDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await SowingReportDatabaseController.SowingReportDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                               
        }

        private async void GetAppointment(Appointment x)
        {
            bool update = false;
            var container = x;
            var appointment = await AppointmentDatabaseController.AppointmentDatabaseInstance(ConnectionString.GetConnection()).GetItemsAsync();
            if ((bool)(appointment.Count > 0))
            {
                int idx = 0;
                for (int i = 0; i < appointment.Count; i++)
                {
                    if ((bool)(x.appointment_id == appointment[i].appointment_id))
                    {
                        update = true;
                        idx = i;
                        break;
                    }
                }

                if (update)
                {
                    x = new Appointment(appointment[idx].id, container.appointment_id, container.customer_id, container.inspector_id, container.title, container.content,  container.date_of_appointment);

                    await AppointmentDatabaseController.AppointmentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
                }
                else
                    await AppointmentDatabaseController.AppointmentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);
            }
            else
                await AppointmentDatabaseController.AppointmentDatabaseInstance(ConnectionString.GetConnection()).SaveItemAsync(container);                                       
        }

        #endregion

    }
}