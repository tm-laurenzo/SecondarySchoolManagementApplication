using hotel_booking_data.UnitOfWork.Implementation;
using SSMA.Core.Abstractions;
using SSMA.Core.Implementations;
using SSMA.Data.UnitOfWork.Abstractions;

namespace SecondarySchoolManagementApplication.Extensions
{
    public static class DIServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            // Add Service Injections Here
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPrincipalService, PrincipalService>();

            // Add Repository Injections Here

            // Add Model Services Injection Here



            // Add Fluent Validator Injections Here

        }
    }
}

