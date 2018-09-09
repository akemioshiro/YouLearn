using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Domain.Entities;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Infra.Persistence.EF.Map
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        // Aqui crio os campos da tabela
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nome da tabela
            builder.ToTable("Usuario");

            // Defino a chave primaria
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Senha).HasMaxLength(36).IsRequired();

            // mapeando objetos de valor ou objetos complexos
            builder.OwnsOne<Nome>(x => x.Nome, cb => {
                cb.Property(x => x.PrimeiroNome).HasMaxLength(50).HasColumnName("PrimeiroNome").IsRequired();
                cb.Property(x => x.UltimoNome).HasMaxLength(50).HasColumnName("UltimoNome").IsRequired();
            });

            builder.OwnsOne<Email>(x => x.Email, cb => {
                cb.Property(x => x.Endereco).HasMaxLength(200).HasColumnName("Email").IsRequired();
            });
        }
    }
}
