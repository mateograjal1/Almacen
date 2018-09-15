using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic
{
    public class Crypto
    {
        public static string Encrypt(string str)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] passEncoded = new UnicodeEncoding().GetBytes(str);
            byte[] result = sha.ComputeHash(passEncoded);
            str = Convert.ToBase64String(result);
            return str;
        }
    }
}
