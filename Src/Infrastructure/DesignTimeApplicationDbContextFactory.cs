using System.Collections.Generic;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Northwind.Infrastructure
{
    public class DesignTimeApplicationDbContextFactory : DesignTimeDbContextFactoryBase<ApplicationDbContext>
    {
        protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> options)
        {
            return new ApplicationDbContext(options, new OptionsManager<OperationalStoreOptions>(new OptionsFactory<OperationalStoreOptions>(new List<IConfigureOptions<OperationalStoreOptions>>(), new List<IPostConfigureOptions<OperationalStoreOptions>>())));
        }
    }
}
