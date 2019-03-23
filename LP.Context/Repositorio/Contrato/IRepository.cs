using System;
using System.Collections.Generic;
using System.Text;

/*
 *  Interface a partir da qual sera montado os repositórios das classes de dominio * 
 */


namespace LP.DAO.Repositorio.Contrato
{
    public interface IRepository<T>
    {
        List<T> getAll();

        T get(long Id);

        void Add(T resource);

        void Upd(T resource);

        void Del(T resource);
    }
}
