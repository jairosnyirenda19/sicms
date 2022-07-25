using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SIMS_BARS.Models
{
    public class ConnectionString
    {
        public ConnectionString(){}

        public static string GetConnection() 
        {
            var sqliteFilename = "Seed_Certification_Management_System_DataCollection";
            string document_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            var path = Path.Combine(document_path, sqliteFilename);
            return path;
        }
    }
}