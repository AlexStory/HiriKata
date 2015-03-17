using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace HiriKata.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string passwordhash { get; set; }
        public string username { get; set; }
        public DateTime CreatedAt { get; set; }
        


        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public bool checkPass(string attempt)
        {
            return GetHashString(attempt + "pepper" + this.CreatedAt.ToString()) == passwordhash;
        }

        public Users() { }

        public Users (string user, string pass)
        {
            this.CreatedAt = DateTime.Now;
            this.username = user;
            this.passwordhash = GetHashString(pass + "pepper" + CreatedAt.ToString() );
        }
    }
}