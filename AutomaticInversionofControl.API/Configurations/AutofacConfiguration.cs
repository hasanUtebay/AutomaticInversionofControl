using Autofac;

namespace AutomaticInversionofControl.API.Configurations;

public static class AutofacConfiguration
{
    public static void AddConfiguredAutoFac(this WebApplicationBuilder builder)
    {
        builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
        {
            containerBuilder.RegisterModule(new APIModule());
        });
    }
}
