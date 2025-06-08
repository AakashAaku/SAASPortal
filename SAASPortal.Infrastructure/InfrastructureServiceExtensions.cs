using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAASPortal.Core.Interfaces;
using SAASPortal.Core.Models;
using SAASPortal.Infrastructure.Data;
using SAASPortal.Infrastructure.Repositories;
using System.Data;

namespace SAASPortal.Infrastructure
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureExtension(this IServiceCollection services,IConfiguration configuration)
        {
           
            //services.AddScoped<IDbConnection>(_ => new SqlConnection(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDbConnection>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                var connectionString = config.GetConnectionString("DefaultConnection");
                return new SqlConnection(connectionString); // Make sure to add: using System.Data.SqlClient;
            });

            services.AddScoped<IAssignmentRepository, AssignmentRepository>();



            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            return services;
        }
    }
}
