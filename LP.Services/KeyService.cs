using LP.DAO.Repositorio.Implementacao;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Services
{
    public static class KeyService
    {
        public static Key GetKeyByUsuarioId(long usuarioId)
        {
            try
            {
                KeyRepository keyRepository = new KeyRepository();
                Key key = keyRepository.getKeyByUsuario(usuarioId);
                if (key != null)
                {
                    return key;
                }
                else
                {
                    throw new Exception("Key não localizada do usuário: " + usuarioId.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
