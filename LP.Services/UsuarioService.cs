using LP.DAO.Repositorio.Implementacao;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Services
{
    public static class UsuarioService
    {
        public static void CadastraUsuarioDemonstracao(string nome, string email, string keyDescriptografada)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                KeyRepository keyRepository = new KeyRepository();
                SaltRepository saltRepository = new SaltRepository();

                if (usuarioRepository.getAll().Count == 0)
                {

                    // Recupero o Salt inicial e o final
                    string salt1 = SaltService.geraSalt();
                    string salt2 = SaltService.geraSalt();

                    // Criptografo a senha
                    string KeyCriptografada = CriptografaService.GetKey(salt1, salt2, keyDescriptografada);

                    // Divido a Senha em duas partes
                    // A idéia á aumentar a segurança gravando a senha do usuário em 
                    // dois locais diferentes. Preferencialmente servidores diferentes
                    string InitialKey = CriptografaService.InitialKey(KeyCriptografada);
                    string FinalKey = CriptografaService.FinalKey(KeyCriptografada);

                    // Crio novo usuario
                    Usuario usuario = new Usuario();
                    usuario.Nome = nome;
                    usuario.Email = email;
                    usuarioRepository.Add(usuario);

                    // Crio nova key
                    Key key = new Key();
                    key.UsuarioId = usuario.Id;
                    key.KeyString = InitialKey;
                    keyRepository.Add(key);

                    // Crio novo Salt e armazeno a parte final da key
                    Salt salt = new Salt();
                    salt.KeyId = key.Id;
                    salt.Salt1 = salt1;
                    salt.Salt2 = salt2;
                    salt.FinalKeyString = FinalKey;

                    // A gravação do Salt e da parte final da key deveria ser realizada através 
                    // de uma chamada a uma outra api, com uma credencial valida.
                    // Por motivos de tempo estou simplificando e chamando diretamente o repositório                
                    saltRepository.Add(salt);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static Usuario GetUsuarioByName (string nome)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                Usuario usuario = usuarioRepository.getUsuarioByName(nome);
                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    throw new Exception("Usuario não localizado - Nome: " + nome);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
