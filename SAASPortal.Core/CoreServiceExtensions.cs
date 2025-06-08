using Microsoft.Extensions.DependencyInjection;
using SAASPortal.Core.Interfaces;
using SAASPortal.Core.Mapper;
using SAASPortal.Core.Services;

namespace SAASPortal.Core
{
    public static class CoreServiceExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {

            services.AddScoped<IAssignmentService, AssignmentService>();
            //services.AddScoped<IAssessmentService, AssessmentService>();

            services.AddAutoMapper(typeof(MappingProfiles));

            return services;
        }
    }
}
