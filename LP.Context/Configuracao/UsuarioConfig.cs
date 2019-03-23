using LP.Domain.Implementacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/*
 *  Classe de configuração das propriedades do usuário
 *  Estas configurações serão utilizadas pelo EF para a
 *  construção da tabela no BD
 * 
 */

namespace LP.DAO.Configuracao
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);     
        }
    }
}
