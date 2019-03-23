using LP.DAO.Contexto;
using LP.DAO.Repositorio.Contrato;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;


/*
 *  Repositorio responsável por manipular os dados da entidade Key
 *  Por uma questão de tempo implementarei apenas as funcionalidades 
 *  que irei utilizar nessa demo
 */


namespace LP.DAO.Repositorio.Implementacao
{
    public class KeyRepository : IRepository<Key>
    {
        public List<Key> getAll()
        {
            throw new NotImplementedException();
        }
    
        public Key get(long Id)
        {
            throw new NotImplementedException();
        }

        public Key getKeyByUsuario(long usuarioId)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                
                Key key = _context.Keys.Where(k => k.UsuarioId == usuarioId).FirstOrDefault();
                if (key != null)
                {
                    return key;
                }
                else
                {
                    throw new Exception("Key não encontrada");
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Add(Key resource)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                _context.Keys.Add(resource);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Upd(Key resource)
        {
            throw new NotImplementedException();
        }

        public void Del(Key resource)
        {
            throw new NotImplementedException();
        }
    }
}
