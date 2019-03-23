using LP.DAO.Contexto;
using LP.DAO.Repositorio.Contrato;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP.DAO.Repositorio.Implementacao
{
    public class SaltRepository : IRepository<Salt>
    {
        public List<Salt> getAll()
        {
            throw new NotImplementedException();
        }

        public Salt get(long Id)
        {
            throw new NotImplementedException();
        }

        public Salt getSaltByKeyId(long keyId)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                Salt salt = _context.Salts.Where(s => s.KeyId == keyId).FirstOrDefault();
                if (salt != null)
                {
                    return salt;
                }
                else
                {
                    throw new Exception("Salt não encontrada");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Add(Salt resource)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                _context.Salts.Add(resource);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Upd(Salt resource)
        {
            throw new NotImplementedException();
        }

        public void Del(Salt resource)
        {
            throw new NotImplementedException();
        }
    }
}
