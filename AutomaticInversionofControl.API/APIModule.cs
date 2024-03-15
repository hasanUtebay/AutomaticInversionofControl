using Autofac;
using AutomaticInversionofControl.API.Concretes.Services;
using AutomaticInversionofControl.API.Contracts.Repositories;
using AutomaticInversionofControl.API.Contracts.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace AutomaticInversionofControl.API;

public class APIModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        /*
         Classic Dependency Injection
         
        builder.RegisterType<ProductionService>().As<IProductionService>().InstancePerLifetimeScope();
         
         */

        var repositoryInterface = typeof(IBaseRepository<>);
        var assembly = Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyTypes(assembly)
            .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == repositoryInterface))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        var serviceInterface = typeof(IScopedService);
        builder.RegisterAssemblyTypes(assembly)
            .Where(type => type.GetInterfaces().Any(i => i == serviceInterface))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
    }
}
