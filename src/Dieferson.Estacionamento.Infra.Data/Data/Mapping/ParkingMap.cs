using Dieferson.Estacionamento.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dieferson.Estacionamento.Infra.Data.Mapping;

public class ParkingMap : IEntityTypeConfiguration<Parking>
{
    public void Configure(EntityTypeBuilder<Parking> builder)
    {
        //Nome da tabela
        builder.ToTable("Parking");

        //Chave Primária
        builder.HasKey(x => x.Id);

        //Identity
        builder.Property(x => x.Id)
        .IsRequired()
        .UseIdentityColumn();

        //Propriedades
        builder.Property(x => x.UpdatedAt)
        .IsRequired()
        .HasColumnName("UpdatedAt")
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValueSql("GETDATE()");

        //Propriedades
        builder.Property(x => x.CreatedAt)
        .IsRequired()
        .HasColumnName("CreatedAt")
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValueSql("GETDATE()");

        //Propriedades
        builder.Property(x => x.CapacityCarOrVan)
        .IsRequired()
        .HasColumnName("CapacityCarOrVan")
        .HasColumnType("INT");

          //Propriedades
        builder.Property(x => x.ActualCapacityCarOrVan)
        .IsRequired()
        .HasColumnName("ActualCapacityCarOrVan")
        .HasColumnType("INT");

          //Propriedades
        builder.Property(x => x.CapacityMotocycle)
        .IsRequired()
        .HasColumnName("CapacityMotocycle")
        .HasColumnType("INT");

          //Propriedades
        builder.Property(x => x.ActualCapacityMotocycle)
        .IsRequired()
        .HasColumnName("ActualCapacityMotocycle")
        .HasColumnType("INT");
    }
}