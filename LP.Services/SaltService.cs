using LP.DAO.Repositorio.Implementacao;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP.Services
{
    public static class SaltService
    {
        public static string geraSalt()
        {
            return RandomString(15);
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public static Salt GetSaltByKey(long keyId)
        {
            try
            {
                SaltRepository saltRepository = new SaltRepository();
                Salt salt = saltRepository.getSaltByKeyId(keyId);
                if (salt != null)
                {
                    return salt;
                }
                else
                {
                    throw new Exception("Salt não localizada para a key: " + keyId);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }


    }
}
