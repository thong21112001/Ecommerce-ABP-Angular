using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EcommerceABP.Data;

/* This is used if database provider does't define
 * IEcommerceABPDbSchemaMigrator implementation.
 */
public class NullEcommerceABPDbSchemaMigrator : IEcommerceABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
