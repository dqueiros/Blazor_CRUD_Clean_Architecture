using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.EntitiesConfiguration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(t => t.LivroId);
            builder.Property(p => p.Titulo).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Autor).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Lancamento).IsRequired();
            builder.Property(p => p.Capa).HasMaxLength(200);
        }
    }
}
