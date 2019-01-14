using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MapJogador : EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            ToTable("Jogador");

            Property(p => p.Email.Endereco)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true}))
                .HasColumnName("Email");

            Property(p => p.Nome.PrimeiroNome)
                .IsRequired()
                .HasColumnName("PrimeiroNome");

            Property(p => p.Nome.UltimoNome)
                .IsRequired()
                .HasColumnName("UltimoNome");

            Property(p => p.Senha)
                .IsRequired();

            Property(p => p.Status)
                .IsRequired();
        }
    }
}
