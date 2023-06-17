using Dieferson.Estacionamento.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dieferson.Estacionamento.Infra.Data.Mapping;

public class PaymentTicketsMap : IEntityTypeConfiguration<PaymentTickets>
{
    public void Configure(EntityTypeBuilder<PaymentTickets> builder)
    {
        //Nome da tabela
        builder.ToTable("PaymentTickets");

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
        builder.Property(x => x.DateEntry)
        .IsRequired()
        .HasColumnName("DateEntry")
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValueSql("GETDATE()");

        //Propriedades
        builder.Property(x => x.DateDeparture)
        .HasColumnName("DateDeparture")
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValueSql("GETDATE()");

        builder.Property(x => x.Payment)
        .HasColumnName("Payment")
        .HasColumnType("FLOAT")
        .HasMaxLength(80);

        //Relacionamento
        builder.HasOne(x => x.Parking)
        .WithMany(x => x.PaymentTickets)
        .HasConstraintName("FK_ParkVehicles_Parking");

        //Relacionamento
        builder.HasOne(x => x.Vehicle)
        .WithMany(x => x.PaymentTickets)
        .HasConstraintName("FK_ParkVehicles_Vehicle")
        .OnDelete(DeleteBehavior.Cascade);

    }


}
