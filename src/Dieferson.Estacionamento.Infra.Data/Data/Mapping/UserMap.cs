using Dieferson.Estacionamento.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dieferson.Estacionamento.Infra.Data.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //Nome da tabela
        builder.ToTable("User");

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
        builder.Property(x => x.Name)
        .IsRequired()
        .HasColumnName("Name")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        //Propriedades
        builder.Property(x => x.Cpf)
        .IsRequired()
        .HasColumnName("Cpf")
        .HasColumnType("INT");

        //Propriedades
        builder.Property(x => x.BirthDate)
        .IsRequired()
        .HasColumnName("BirthDate")
        .HasColumnType("SMALLDATETIME")
        .HasDefaultValueSql("GETDATE()");
    }
}