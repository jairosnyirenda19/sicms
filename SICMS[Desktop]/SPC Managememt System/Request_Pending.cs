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
    public partial class Request_Pending : UserControl
    {
        public Request_Pending()
        {
            InitializeComponent();
        }

        #region
        private string sowing_id;
        private string request_id;
        private string name;
        private string crop;
        private string _date;
        private string inspectiontype;
        public string Sowing_Id
        {
            get { return sowing_id; }
            set { sowing_id = value; }
        }

        public string Request_Id
        {
            get { return request_id; }
            set { request_id = value; }
        }
        [Category("Custom Propeties")]
        public string ClientName
        {
            get { return name; }
            set { name = value; LblName.Text = value; }
        }

        [Category("Custom Propeties")]
        public string Crop
        {
            get { return crop; }
            set { crop = value; LblSeed.Text = value; }
        }

        [Category("Custom Propeties")]
        public string _Date
        {
            get { return _date; }
            set { _date = value; LblDate.Text = value; }
        }

        [Category("Custom Propeties")]
        public string Inspectiontype
        {
            get { return inspectiontype; }
            set { inspectiontype = value; LblInspectionType.Text = value; }
        }
        #endregion
    }
}
