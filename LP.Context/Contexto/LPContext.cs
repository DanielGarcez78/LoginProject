using LP.DAO.Configuracao;
using LP.Domain.Implementacao;
using Microsoft.EntityFrameworkCore;

/*
 *  Classe de definição do contexto da aplicação
 *  Nesta classe serão definidos os dominios da aplicação 
 * 
 */


namespace LP.DAO.Contexto
{
    public class LPContext : DbContext
    {
        public LPContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        #region Tables
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<Salt> Salts { get; set; }
        #endregion

        /*
         *  Método que add as configurações das entidades de dominio para a realização do Migration
         */
        private void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new KeyConfig());
            modelBuilder.ApplyConfiguration(new SaltConfig());
        }
    }
}
