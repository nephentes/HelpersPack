using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack
{

    public static class ShaHelper
    {
        static public string GetHash(string input)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] inputbytes = UTF8Encoding.UTF8.GetBytes(input);
            byte[] hash = sha.ComputeHash(inputbytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }

}

