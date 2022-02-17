﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AppStock.App_Code
{
    public class Helper
    {
        public static string GetMd5Hash(MD5 md5Hash, String input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static object VerifyMd5Hash(object md5Hash, string text, object motDePasse)
        {
            throw new NotImplementedException();
        }

        internal static bool verifyMd5Hash(MD5 md5Hash, string text, object motDePasse)
        {
            throw new NotImplementedException();
        }

        internal static object GetMd5Hash(object md5Hash, string v)
        {
            throw new NotImplementedException();
        }
    }
}
