using Microsoft.EntityFrameworkCore;
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
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ETicaretAPIDb;"));
        }
    }
}
