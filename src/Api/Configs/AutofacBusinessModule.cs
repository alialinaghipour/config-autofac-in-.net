using Api.Contracts;
using Api.Services;
using Autofac;

namespace Api.Configs;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var webApiAssembly = typeof(DateTimeAppService).Assembly;
        
        builder.RegisterAssemblyTypes(webApiAssembly)
            .AssignableTo<ISingleton>()
            .AsImplementedInterfaces()
            .SingleInstance();

        builder.RegisterAssemblyTypes(webApiAssembly)
            .AssignableTo<ITransient>()
            .AsImplementedInterfaces()
            .InstancePerDependency();

        builder.RegisterAssemblyTypes(webApiAssembly)
            .AssignableTo<IScope>()
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        // builder.RegisterType<DateTimeAppService>()
        //     .As<IDateTimeService>()
        //     .InstancePerLifetimeScope();
        
        base.Load(builder);
    }
}