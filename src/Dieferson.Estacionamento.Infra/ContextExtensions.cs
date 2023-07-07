using Dieferson.Estacionamento.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dieferson.Estacionamento.Infra;

public class ContextExtension {
    public static void AddContext(IServiceCollection services, string connectionString) {
        services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer(connectionString)
        );
    }
}