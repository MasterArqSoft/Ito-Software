using CodeFirst.Core.Features.PersonaServices;
using CodeFirst.Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CodeFirst.Core
{
    public static class ServiceRegistration
    {
        public static void AddCoreLayer(this IServiceCollection services)
        {
            services.AddTransient<IPersonaService, PersonaService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
