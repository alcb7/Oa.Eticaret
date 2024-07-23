using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OA.ETicaret.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.ETicaret.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/OA.ETicaret.WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(configurationManager.GetConnectionString("PostgreSQL")));
        }
    }
}
