using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EcommerceABP.Data;
using Volo.Abp.DependencyInjection;

namespace EcommerceABP.EntityFrameworkCore;

public class EntityFrameworkCoreEcommerceABPDbSchemaMigrator
    : IEcommerceABPDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEcommerceABPDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EcommerceABPDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EcommerceABPDbContext>()
            .Database
            .MigrateAsync();
    }
}
