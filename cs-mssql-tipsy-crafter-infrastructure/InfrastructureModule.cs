namespace AmritaDb.Tipsy.Infrastructure;

using Autofac;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class InfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.Register(context =>
        {
            var config = context.Resolve<IConfiguration>();
            var optionsBuilder = new DbContextOptionsBuilder<AmritaTipsyDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("AmritaTipsyDb"));
            return new AmritaTipsyDbContext(optionsBuilder.Options);
        }).InstancePerLifetimeScope();
    }
}