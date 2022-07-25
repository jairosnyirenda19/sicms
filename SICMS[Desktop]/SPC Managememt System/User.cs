using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Managememt_System
{
    class User
    {
        private string initVector;
        private const int keysize = 256;


        protected string fname;
        protected string lname;
        protected string email;
        protected string contact;
        protected string username;
        protected string accountType;

        public User() { }
        public User(string fname, string lname, string email, string contact, string username, string accountType) { }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }


        protected virtual DataTable GetUsers(string Table= null, string[] Condition = null, string Query = null)
        {
            var x = new DataTable();
            if (Condition != null)
            {
                DB.GetInstance().Get(Table, Condition);
                x = DB.GetInstance().dt;
            }
            else
                x = DB.GetInstance().Query(Query);
            return x;
        }

        protected virtual int Count(string Table = null, string[] Condition = null, string Query = null)
        {
            var x = new DataTable();
            if (Condition.Length == 3)
            {
                DB.GetInstance().Get(Table, Condition);
                x = DB.GetInstance().dt;
            }
            else
                x = DB.GetInstance().Query(Query);
            return x.Rows.Count;
        }

        protected virtual bool InsertSIOs(Dictionary<string, string> x = null, string Query = null, string Table = null)
        {
            if (x != null && Table != null)
            {
                DB.GetInstance().Insert(Table, x);
                return true;
            }
            else if(Query != null)
            {
                DB.GetInstance().Query(Query);
                return true;
            }else
                return false;
        }

        protected virtual string GenerateRand(string signature)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;
            int length = 0;

            if ((bool)(signature == "password"))
                length = 8;
            else
                length = 18;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        protected virtual string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        protected virtual string ComputeSha256Hash(string x, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(x + salt));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        protected virtual string SymmetricKeyAlgorithm(string plainText, string passPhrase = null)
        {
            initVector = GenerateRand("");
            passPhrase = MD5Hash(GenerateRand(""));
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            var symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            var memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public bool Login(string uname, string pwrd)
        {
            var condition = new[] { "username", "=", uname };
            var x = DB.GetInstance().Get("user_account", condition);
            var z = DB.GetInstance().dt;
            if (z.Rows.Count > 0)
            {
                try
                {
                    string salt = z.Rows[0]["salt"].ToString();
                    string Query = "SELECT * FROM user_account " +
                        "WHERE username = '"+uname+"' " +
                        "AND password = '"+ ComputeSha256Hash(pwrd, salt) + "'";
                    z = DB.GetInstance().Query(Query);
                    if (z.Rows.Count > 0)
                    {
                        z = DB.GetInstance().dt;
                        string a = z.Rows[0]["account_type"].ToString();
                        return (a == "Inspection Director") ? true : false;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch { }
            }            
            return false;
        }
    }
}
