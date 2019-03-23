using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Services
{
    public static class CriptografaService
    {
        public static string GetKey(string salt1, string salt2, string key)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(salt1 + key + salt2);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
                return hash;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static string InitialKey(string key)
        {
            try
            {
                int len = key.Length;
                if (len % 2 == 0)
                {
                    return key.Substring(0, (len / 2));
                }
                else
                {
                    return key.Substring(0, ((len + 1) / 2));
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string FinalKey(string key)
        {
            try
            {
                int len = key.Length;
                if (len % 2 == 0)
                {
                    return key.Substring(((len / 2)), ((len -1) - ((len / 2) - 1)));
                }
                else
                {
                    return key.Substring(((len + 1) / 2), ((len - 1) - ((len / 2) - 2)));
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
