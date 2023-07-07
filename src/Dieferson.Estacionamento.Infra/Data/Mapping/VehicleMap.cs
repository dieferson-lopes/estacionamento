using Dieferson.Estacionamento.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dieferson.Estacionamento.Infra.Data.Mapping;

public class VehicleMap : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        //Nome da tabela
        builder.ToTable("Vehicle");

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
        builder.Property(x => x.LicensePlate)
        .IsRequired()
        .HasColumnName("LicensePlate")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        //Propriedades
        builder.Property(x => x.Model)
        .IsRequired()
        .HasColumnName("Model")
        .HasColumnType("INT");

        //Relacionamento um para muitos
        builder.HasOne(x => x.User)
        .WithMany(x => x.Vehicles)
        .HasConstraintName("FK_Vehicle_User");

        //Relacionamento um para um
        // builder.OwnsOne(x => x.ParkVehicle)
        // .WithOwner(x => x.Vehicle)
        // .HasConstraintName("FK_Vehicle_User");
    }
}