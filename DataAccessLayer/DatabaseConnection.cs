using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public static class DatabaseConnection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExamDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IDbRepository, DbRepository>();

            return services;
        }
    }
}
