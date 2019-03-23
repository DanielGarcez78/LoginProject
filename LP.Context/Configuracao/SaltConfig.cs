using LP.Domain.Implementacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LP.DAO.Configuracao
{
    public class SaltConfig : IEntityTypeConfiguration<Salt>
    {
        public void Configure(EntityTypeBuilder<Salt> builder)
        {

            builder.HasKey(s => s.Id);

            builder.Property(s => s.KeyId)
                .IsRequired();

            builder.Property(p => p.Salt1)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Salt2)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.FinalKeyString)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}
