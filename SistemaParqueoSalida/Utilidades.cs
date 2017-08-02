using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemaParqueoSalida
{
    class Utilidades
    {
       

        public static string EncodePassword(string Pass)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(Pass);
            byte[] hash = sha1.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
