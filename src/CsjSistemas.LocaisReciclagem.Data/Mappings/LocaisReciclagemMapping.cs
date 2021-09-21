using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CsjSistemas.LocaisReciclagem.Domain;

namespace CsjSistemas.LocaisReciclagem.Data.Mappings
{
    public class LocaisReciclagemMapping : IEntityTypeConfiguration<Domain.Entity.LocaisReciclagem>
    {
        public void Configure(EntityTypeBuilder<Domain.Entity.LocaisReciclagem> builder)
        {

            builder.HasKey(c => c.LocalReciclagem_Id);
            builder.Property(c => c.Identificacao).HasColumnType("varchar(100)");
            builder.Property(c => c.CEP).HasColumnType("varchar(10)");
            builder.Property(c => c.Logradouro).HasColumnType("varchar(100)");
            builder.Property(c => c.NumeroEndereco).HasColumnType("varchar(10)");
            builder.Property(c => c.Complemento).HasColumnType("varchar(30)");
            builder.Property(c => c.Bairro).HasColumnType("varchar(50)");
            builder.Property(c => c.Cidade).HasColumnType("varchar(50)");
            builder.Property(c => c.Capacidade).HasColumnType("float");
            builder.Property(c => c.Latitude).HasColumnType("varchar(100)");
            builder.Property(c => c.Longitude).HasColumnType("varchar(100)");

            builder.ToTable("LocaisReciclagem");
        }
    }
}
