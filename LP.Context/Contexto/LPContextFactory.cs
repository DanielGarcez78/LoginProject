using Microsoft.EntityFrameworkCore;

/*
 * Classe responsavel pela criação do contexto para utilização nos repositorios
 */

namespace LP.DAO.Contexto
{
    public static class LPContextFactory
    {
        private static LPContext lpContext = null;

        public static LPContext GetContext()
        {
            if (lpContext == null)
            {
                DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<LPContext>();
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", 
                    m => m.MigrationsAssembly("LP.DAO"));
                lpContext = new LPContext(optionsBuilder.Options);
            }
            return lpContext;
        }
    }

}
