using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_Managememt_System
{
    public partial class Sowing_Report_Page : UserControl
    {
        public Sowing_Report_Page()
        {
            InitializeComponent();
        }

        #region Properties
        private string sowing_id;
        private string clientname;
        private string crop;
        private string certificationNo;
        private int countInspections;
        private string variety;
        private double acreage;
        private string location;
        private string seed_class;
        private int quantity;
        private DateTime sowing_date;
        private string source;
        private string tag_number;
        private string purchaseBillNo;
        private DateTime date_seeds_bought;
        private string bankAcknowledgement;
        private string bankname;
        private string mobileAcknowledgement;
        private string servicename;
        private string transcation_id;

        public static string path_deposit
        {
            private get;
            set;
        }
        public static string path_tag
        {
            private get;
            set;
        }
        public static string path_bill
        {
            private get;
            set;
        }


        [Category("Lable Values")]

        public string Sowing_id
        {
            get { return sowing_id; }
            set { sowing_id= value; }
        }

        public string Clientname
        {
            get { return Clientname; }
            set { clientname = value; LblClientName.Text = value; }
        }

        [Category("Lable Values")]
        public string Crop
        {
            get { return crop; }
            set { crop = value; LblCropname.Text = value; }
        }

        [Category("Lable Values")]
        public  string CertificationNo
        {
            get { return certificationNo; }
            set { certificationNo = value; LblCertificationNo.Text = value; }
        }


        [Category("Lable Values")]
        public string Variety
        {
            get { return variety; }
            set { variety = value; LblVariety.Text = value; }
        }

        [Category("Lable Values")]
        public int CountInspections
        {
            get { return countInspections; }
            set { countInspections = value; CountInspectionsConducted.Value = value; }
        }

        [Category("Lable Values")]
        public double Acreage
        {
            get { return acreage; }
            set { acreage = value; LblAcreage.Text = value.ToString(); }
        }

        [Category("Lable Values")]
        public string _Location
        {
            get { return location; }
            set { location = value; LblLocation.Text = value; }
        }

        [Category("Lable Values")]
        public string Seed_Class
        {
            get { return seed_class; }
            set { seed_class = value;  LblClass.Text = value; }
        }

        [Category("Lable Values")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; LblQuantity.Text = value.ToString(); }
        }

        [Category("Lable Values")]
        public DateTime Sowing_Date
        {
            get { return sowing_date; }
            set { sowing_date = value; LblDateOfSowing.Text = sowing_date.ToShortDateString(); }
        }

        [Category("Lable Values")]
        public string Source
        {
            get { return source; }
            set { source = value; LblSource.Text = value; }
        }

        [Category("Lable Values")]
        public string Tag_Number
        {
            get { return tag_number; }
            set { tag_number = value; LblTagNumber.Text = value; }
        }

        [Category("Lable Values")]
        public string PurchaseBillNo
        {
            get { return purchaseBillNo; }
            set { purchaseBillNo = value; LblPurchaseBillNo.Text = value; }
        }

        [Category("Lable Values")]
        public DateTime Date_Seeds_Bought
        {
            get { return date_seeds_bought; }
            set { date_seeds_bought = value; LblDateBought.Text = value.ToShortDateString(); }
        }
        
        [Category("Lable Values")]
        public string BankAcknowledgement
        {
            get { return bankAcknowledgement; }
            set { bankAcknowledgement = value; LblAcknowledgeBankUsed.Text = value; }
        }

        [Category("Lable Values")]
        public string Bankname
        {
            get { return bankname; }
            set { bankname = value; LblBankName.Text = value; }
        }

        [Category("Lable Values")]
        public string MobileAcknowledgement
        {
            get { return mobileAcknowledgement; }
            set { mobileAcknowledgement = value; LblAcknowledgeMobileUsed.Text = value; }
        }

        [Category("Lable Values")]
        public string Servicename
        {
            get { return servicename; }
            set { servicename = value; LblMobileService.Text = "Service: " + value; }
        }

        [Category("Lable Values")]
        public string Transcation_Id
        {
            get { return transcation_id; }
            set { transcation_id = value; LblTransactionId.Text = "Trans ID: " + value;}
        }
        #endregion

        private void Sowing_Report_Page_Load(object sender, EventArgs e)
        {
            LinkLblViewDepositSlip.Text = (path_deposit != "") ? "View Deposit Slip": "N/A";
            LinkLblTagSource.Text = (path_tag != "") ? "View Tag": "N/A";
            LinkLblViewPurchaseBill.Text = (path_bill != "") ? "View Purchase Bill": "N/A";
        }

        private void LinkLblViewDepositSlip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkLblViewDepositSlip.Text != "N/A")
            {
                var x = new ImagePreview(path_deposit);
                x.ShowDialog();
            }
        }

        private void LinkLblTagSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkLblTagSource.Text != "N/A")
            {
                var x = new ImagePreview(path_tag);
                x.ShowDialog();
            }
        }

        private void LinkLblViewPurchaseBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkLblViewPurchaseBill.Text != "N/A")
            {
                var x = new ImagePreview(path_bill);
                x.ShowDialog();
            }
        }

        private void LinkLblViewInspectionsConducted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = new InspectionList(sowing_id);
            Sowing_Report.InvokeOpenForm(x);
        }
    }
}
