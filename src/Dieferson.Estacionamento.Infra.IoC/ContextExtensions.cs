using Dieferson.Estacionamento.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dieferson.Estacionamento.Infra.Ioc;

public class ContextExtension {
    public static void AddContext(IServiceCollection services, string connectionString) {
        services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer(connectionString)
        );
    }
}