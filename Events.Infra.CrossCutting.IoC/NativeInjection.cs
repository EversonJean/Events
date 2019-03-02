using AutoMapper;
using Events.Application.Interfaces;
using Events.Application.Services;
using Events.Domain.Interfaces;
using Events.Domain.Interfaces.Service;
using Events.Domain.Services;
using Events.Infra.Data.Context;
using Events.Infra.Data.Repository;
using Events.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Events.Infra.CrossCutting.IoC
{
    public class NativeInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterServicesApplication(services);

            RegisterServicesDomain(services);

            RegisterServicesDataContext(services);
        }

        private static void RegisterServicesApplication(IServiceCollection services)
        {
            //Auto Mapper
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(x => new Mapper(x.GetRequiredService<IConfigurationProvider>(), x.GetService));

            //Services
            services.AddScoped<IEventAppService, EventAppService>();
        }

        private static void RegisterServicesDomain(IServiceCollection services)
        {
            //Services
            services.AddScoped<IEventService, EventService>();
        }

        private static void RegisterServicesDataContext(IServiceCollection services)
        {
            //Context
            services.AddScoped<EventContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repository
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}
