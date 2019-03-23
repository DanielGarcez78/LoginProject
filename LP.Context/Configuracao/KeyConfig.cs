using LP.Domain.Implementacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/* 
 *  Classe de configuração das propriedades da Key
 *  Estas configurações serão utilizadas pelo EF para a
 *  construção da tabela no BD 
 */

namespace LP.DAO.Configuracao
{
    public class KeyConfig : IEntityTypeConfiguration<Key>
    {
        public void Configure(EntityTypeBuilder<Key> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(k => k.UsuarioId)
                .IsRequired();

            builder.Property(k => k.KeyString)
                .IsRequired()
                .HasMaxLength(1000);

        }
    }
}
