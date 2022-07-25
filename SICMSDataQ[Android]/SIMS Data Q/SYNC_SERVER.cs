using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;


namespace SIMS_BARS
{
    public class SYNC_SERVER
    {
        #region DOWNLOAD

        public string SYNC_APPOINTMENTS;
        public string SYNC_BANK_SERVICE ;
        public string SYNC_CERTIFICATION ;
        public string SYNC_CLASS ;
        public string SYNC_CLIENTS ;
        public string SYNC_CROP ;
        public string SYNC_MOBILE_SERVICE ;
        public string SYNC_PAYMENT_METHOD ;
        public string SYNC_PAYMENT_DETAILS ;
        public string SYNC_SOWING_REPORT ;
        public string SYNC_VARIETY ;
        public string SYNC_LOGIN ;

        #endregion

        #region UPLOAD

        public string SYNC_UPLOAD_PRE_FLOWERING;
        public string SYNC_UPLOAD_FLOWERING;
        public string SYNC_UPLOAD_POST_FLOWERING;
        public string SYNC_UPLOAD_HARVEST;

        #endregion
        

        public SYNC_SERVER(string ip_address, int port) 
        {
            SYNC_APPOINTMENTS = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_APPOINTMENTS.php";
            SYNC_BANK_SERVICE = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_BANK_SERVICE.php";
            SYNC_CERTIFICATION = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_CERTIFICATION.php";
            SYNC_CLASS = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_CLASS.php";
            SYNC_CLIENTS = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_CLIENTS.php"; 
            SYNC_CROP = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_CROP.php";
            SYNC_MOBILE_SERVICE = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_MOBILE_SERVICE.php";
            SYNC_PAYMENT_METHOD = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_PAYMENT_METHOD.php";
            SYNC_PAYMENT_DETAILS = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_PAYMENT_DETAILS.php";
            SYNC_SOWING_REPORT = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_SOWING_REPORT.php";
            SYNC_VARIETY = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_VARIETY.php";
            SYNC_LOGIN = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_LOGIN.php";

            SYNC_UPLOAD_PRE_FLOWERING = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_UPLOAD_PRE_FLOWERING.php";
            SYNC_UPLOAD_FLOWERING = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_UPLOAD_FLOWERING.php";
            SYNC_UPLOAD_POST_FLOWERING = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_UPLOAD_POST_FLOWERING.php";
            SYNC_UPLOAD_HARVEST = "http://" + ip_address + ":" + port + "/SPCMS/SYNC/SYNC_UPLOAD_HARVEST.php";
        }
    }
}