using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Abstracts.Products;
using Onion.Persistence.Concretes.Products;
using Onion.Persistence.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistence.Extesions
{
    public static class ServiceRegistration
    {
        public static void RegisterPersistenceService(this IServiceCollection services)
        {
            ConfigurationManager config = new();
            config.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../presentation/onion.webapi"));
            config.AddJsonFile("appsettings.json");

            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<DataBase>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConection"));
            });
        }
    }
}
