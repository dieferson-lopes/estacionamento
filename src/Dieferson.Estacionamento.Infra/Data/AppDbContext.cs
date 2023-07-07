using System.Reflection;
using Dieferson.Estacionamento.Core.Entities;
using Dieferson.Estacionamento.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Dieferson.Estacionamento.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<PaymentTickets> ParkVehicles { get; set; }
    public DbSet<Parking> Parkings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ParkingMap());
        modelBuilder.ApplyConfiguration(new PaymentTicketsMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new VehicleMap());
    }
}