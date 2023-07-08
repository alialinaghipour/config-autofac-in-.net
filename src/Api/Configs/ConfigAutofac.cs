using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace Api.Configs;

public static class ConfigAutofac
{
    internal static void AddConfigAutofac(this ConfigureHostBuilder builder)
    {
        builder.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        builder.ConfigureContainer<ContainerBuilder>(b =>
            b.RegisterModule(new AutofacBusinessModule())
        );
    } 
}