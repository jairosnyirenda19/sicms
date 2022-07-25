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
using Android.Graphics;
using System.IO;
using Android.Media;

namespace SIMS_BARS
{
    [Activity(Label = "Sowing Report (1)", Icon = "@drawable/icon")]
    public class Sowing_Report_Page : Activity
    {
        private TextView TextClientName;
        private TextView TextCropName;
        private TextView TextCertificationNo;
        private TextView TextCoordinates;
        private TextView TextVariety;
        private TextView TextAcreage;
        private TextView TextClass;
        private TextView TextSeedsUsed;
        private TextView TextDateOfSowing;
        private TextView TextSource;
        private TextView TextTagNo;
        private TextView TextPurchaseBill;
        private TextView TextDateBought;
        private TextView TextBankAcknowledgement;
        private TextView TextBankName;
        private TextView TextViewDepositSlip;
        private TextView TextMobileAcknowledgement;
        private TextView TextMobileServiceName;
        private TextView TextTransactionId;
        private TextView TextViewTagSource;
        private TextView TextViewPurchaseBill;

        private int payment_idx;
        private int sowing_idx;
        public static Bitmap Image;

        public static int sowingreport_idx;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SowingReport_Page);

            TextClientName = FindViewById<TextView>(Resource.Id.TextClientName);
            TextCropName = FindViewById<TextView>(Resource.Id.TextCropName);
            TextCertificationNo = FindViewById<TextView>(Resource.Id.TextCertificationNo);
            TextCoordinates = FindViewById<TextView>(Resource.Id.TextCoordinates);
            TextVariety = FindViewById<TextView>(Resource.Id.TextVariety);
            TextAcreage = FindViewById<TextView>(Resource.Id.TextAcreage);
            TextClass = FindViewById<TextView>(Resource.Id.TextClass);
            TextSeedsUsed = FindViewById<TextView>(Resource.Id.TextSeedsUsed);
            TextDateOfSowing = FindViewById<TextView>(Resource.Id.TextDateOfSowing);
            TextSource = FindViewById<TextView>(Resource.Id.TextSource);
            TextTagNo = FindViewById<TextView>(Resource.Id.TextTagNo);
            TextPurchaseBill = FindViewById<TextView>(Resource.Id.TextPurchaseBill);
            TextDateBought = FindViewById<TextView>(Resource.Id.TextDateBought);
            TextBankAcknowledgement = FindViewById<TextView>(Resource.Id.TextBankAcknowledgement);
            TextBankName = FindViewById<TextView>(Resource.Id.TextBankName);
            TextViewDepositSlip = FindViewById<TextView>(Resource.Id.TextViewDepositSlip);
            TextMobileAcknowledgement = FindViewById<TextView>(Resource.Id.TextMobileAcknowledgement);
            TextMobileServiceName = FindViewById<TextView>(Resource.Id.TextMobileServiceName);
            TextTransactionId = FindViewById<TextView>(Resource.Id.TextTransactionId);
            TextViewTagSource = FindViewById<TextView>(Resource.Id.TextViewTagSource);
            TextViewPurchaseBill = FindViewById<TextView>(Resource.Id.TextViewPurchaseBill);

            TextViewDepositSlip.Click += TextViewDepositSlip_Click;
            TextViewTagSource.Click += TextViewTagSource_Click;
            TextViewPurchaseBill.Click += TextViewPurchaseBill_Click;


            GetSowingReport();
        }

        void TextViewPurchaseBill_Click(object sender, EventArgs e)
        {
            if (TextViewPurchaseBill.Text == "N/A")
                Toast.MakeText(this, "There's no purchase bill to view", ToastLength.Short).Show();
            else
            {
                var sowing = Sowing_Inspection_Options.sowingreport;
                Image = ConvertImage(sowing[sowing_idx].purchaseBill);
                Intent intent = new Intent(this, typeof(ImageViewer_View));
                this.StartActivity(intent);
            }
        }

        void TextViewTagSource_Click(object sender, EventArgs e)
        {
            if (TextViewTagSource.Text == "N/A")
                Toast.MakeText(this, "There's no tag source to view", ToastLength.Short).Show();
            else
            {
                var sowing = Sowing_Inspection_Options.sowingreport;
                Image = ConvertImage(sowing[sowing_idx].tagSrc);
                Intent intent = new Intent(this, typeof(ImageViewer_View));
                this.StartActivity(intent);
            }
        }

        void TextViewDepositSlip_Click(object sender, EventArgs e)
        {
            if (TextViewDepositSlip.Text == "N/A")
                Toast.MakeText(this, "There's no bank deposit slip to view", ToastLength.Short).Show();
            else
            {
                var payment = Sowing_Inspection_Options.payment;
                Image = ConvertImage(payment[payment_idx].bank_deposit_slip);
                Intent intent = new Intent(this, typeof(ImageViewer_View));
                this.StartActivity(intent);
            }
        }

        private Bitmap ConvertImage(byte[] array)
        {
            var imageBitmap = BitmapFactory.DecodeByteArray(array, 0, array.Length);
            return imageBitmap;
        }

        private void GetSowingReport() 
        {
            try
            {
                int idx = sowingreport_idx = SowingReport_on_client.sowing_id;
                var x = Sowing_Inspection_Options.sowingreport;
                string seedclass = string.Empty;
                var sowingreport = Sowing_Inspection_Options.sowingreport;
                var payment_method = Sowing_Inspection_Options.paymentmethod;
                var payment = Sowing_Inspection_Options.payment;
                var mobile = Sowing_Inspection_Options.mobile;
                var bank = Sowing_Inspection_Options.bank;
                string name = string.Empty;
                string crop = string.Empty;
                string certification = string.Empty;
                string location = string.Empty;
                string variety = string.Empty;

                int payment_id = sowingreport[idx].payment_id;
                payment_idx = 0;
                int bank_idx = 0;
                int service_idx = 0;
                name = Clients.clientsname;

                for (int i = 0; i < Sowing_Inspection_Options.crop.Count; i++)
                {
                    if (Sowing_Inspection_Options.crop[i].crop_id == x[idx].crop_id)
                    {
                        crop = Sowing_Inspection_Options.crop[i].crop;
                        break;
                    }
                }

                for (int i = 0; i < Sowing_Inspection_Options.certification.Count; i++)
                {
                    if (Sowing_Inspection_Options.certification[i].certification_id == x[idx].certification_id)
                    {
                        certification = Sowing_Inspection_Options.certification[i].certification_no;
                        break;
                    }
                }

                if (Sowing_Inspection_Options.certification.Count > 0)
                    for (int i = 0; i < Sowing_Inspection_Options.certification.Count; i++)
                    {
                        if (Sowing_Inspection_Options.certification[i].certification_id == x[idx].certification_id)
                        {
                            certification = Sowing_Inspection_Options.certification[i].certification_no;
                            break;
                        }
                    }

                for (int i = 0; i < Sowing_Inspection_Options.variety.Count; i++)
                {
                    if (Sowing_Inspection_Options.variety[i].variety_id == x[idx].variety_id)
                    {
                        variety = Sowing_Inspection_Options.variety[i].variety;
                        break;
                    }
                }

                for (int i = 0; i < Sowing_Inspection_Options.seedclass.Count; i++)
                {
                    if (Sowing_Inspection_Options.seedclass[i].class_id == x[idx].class_id)
                    {
                        seedclass = Sowing_Inspection_Options.seedclass[i].class_name + ": " + Sowing_Inspection_Options.seedclass[i].genetic_purity;
                        break;
                    }
                }

                for (int i = 0; i < payment.Count; i++)
                    if (payment[i].payment_id == payment_id)
                    {
                        payment_idx = i;
                        break;
                    }

                for (int i = 0; i < bank.Count; i++)
                    if (payment[payment_idx].bank_id == bank[i].bank_id)
                    {
                        bank_idx = i;
                        break;
                    }

                for (int i = 0; i < mobile.Count; i++)
                    if (payment[payment_idx].mobile_id == mobile[i].mobile_id)
                    {
                        service_idx = i;
                        break;
                    }

                TextClientName.Text = (name != string.Empty) ? name : "N/A";
                TextCropName.Text = (crop != string.Empty) ? crop : "N/A";
                TextCertificationNo.Text = (certification != string.Empty) ? "Certification No.:" + certification : "Certification No.: N/A";
                TextCoordinates.Text = (location != string.Empty) ? location : "N/A";
                TextVariety.Text = (variety != string.Empty) ? variety : "N/A";
                TextAcreage.Text = (x[idx].acreage.ToString() != "") ? x[idx].acreage.ToString() : "N/A";
                TextClass.Text = (seedclass != string.Empty) ? seedclass : "N/A";
                TextSeedsUsed.Text = (x[idx].quantity_per_acrea.ToString() != "") ? x[idx].quantity_per_acrea.ToString() : "N/A";

                TextDateOfSowing.Text = (x[idx].date_of_sowing.ToString() != "") ? x[idx].date_of_sowing.ToShortDateString() : "N/A";
                TextSource.Text = (x[idx].seed_source != "") ? x[idx].seed_source : "N/A";
                TextTagNo.Text = (x[idx].tag_number != "") ? x[idx].tag_number : "N/A";
                TextPurchaseBill.Text = (x[idx].purchase_bill_no != "") ? x[idx].purchase_bill_no : "N/A";
                TextDateBought.Text = (x[idx].date_of_purchase.ToString() != "") ? x[idx].date_of_purchase.ToShortDateString() : "N/A";

                string bankAcknowledge = (payment[payment_idx].bank_id != 0) ? "Yes" : "No";
                string bank_name = (bank[bank_idx].bank_id != 0) ? bank[bank_idx].bank_name + " - " + bank[bank_idx].account_number : "N/A";
                string viewdeposit = (payment[payment_idx].bank_deposit_slip != null) ? "View Deposit Slip" : "N/A";
                string mobileAcknoledge = (payment[payment_idx].mobile_id != 0) ? "Yes" : "No";
                string service_name = (mobile[service_idx].mobile_id != 0) ? "Yes" : "No";
                string transactionid = (payment[payment_idx].transaction_id != "null") ? (payment[payment_idx].transaction_id != "") ? payment[payment_idx].transaction_id : "N/A" : "N/A";
                string viewtagsrc = (sowingreport[idx].tagSrc != null) ? "View Tag Source" : "N/A";
                string viewpurchasebill = (sowingreport[idx].purchaseBill != null) ? "View Purchase Bill" : "N/A";

                TextBankAcknowledgement.Text = bankAcknowledge;
                TextBankName.Text = bank_name;
                TextViewDepositSlip.Text = viewdeposit;
                TextMobileAcknowledgement.Text = mobileAcknoledge;
                TextMobileServiceName.Text = service_name;
                TextTransactionId.Text = transactionid;
                TextViewTagSource.Text = viewtagsrc;
                TextViewPurchaseBill.Text = viewpurchasebill;
            }
            catch { }
        }
    }
}