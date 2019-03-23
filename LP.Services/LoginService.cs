using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Services
{
    public static class LoginService
    {
        public static bool ValidaLogin(string nome, String senha)
        {
            try
            {
                // Recupero o usuario
                Usuario usuario = UsuarioService.GetUsuarioByName(nome);
                Key key = KeyService.GetKeyByUsuarioId(usuario.Id);

                // A recupoeração deste registro deveria ser realizado por uma API 
                // utilizando algum metodo de autenticação e autorizacao
                Salt salt = SaltService.GetSaltByKey(key.Id);

                string KeyComplete = key.KeyString + salt.FinalKeyString;
                string KeyComparation = CriptografaService.GetKey(salt.Salt1, salt.Salt2, senha);

                return KeyComplete == KeyComparation;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
                return false;
            }

        }
    }

}
