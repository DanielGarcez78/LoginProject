using LP.DAO.Contexto;
using LP.DAO.Repositorio.Contrato;
using LP.Domain.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;


/*
 *  Repositorio responsável por manipular os dados da entidade Usuario 
 *  Por uma questão de tempo implementarei apenas as funcionalidades 
 *  que irei utilizar nessa demo
 */

namespace LP.DAO.Repositorio.Implementacao
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        public List<Usuario> getAll()
        {
            var _context = LPContextFactory.GetContext();
            return _context.Usuarios.ToList();

        }

        public Usuario get (long Id)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                
                Usuario usuario = _context.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    throw new Exception("Usuario não localizado");
                }                    
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Usuario getUsuarioByName(string nome)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                Usuario usuario = _context.Usuarios.Where(u => u.Nome == nome).FirstOrDefault();
                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    throw new Exception("Usuario não localizado");
                }                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Add(Usuario resource)
        {
            try
            {
                var _context = LPContextFactory.GetContext();
                _context.Usuarios.Add(resource);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Upd(Usuario resource)
        {
            throw new NotImplementedException();
        }

        public void Del(Usuario resource)
        {
            throw new NotImplementedException();
        }

    }
}
