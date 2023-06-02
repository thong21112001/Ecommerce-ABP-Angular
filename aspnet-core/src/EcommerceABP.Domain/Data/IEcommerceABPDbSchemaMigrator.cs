using System.Threading.Tasks;

namespace EcommerceABP.Data;

public interface IEcommerceABPDbSchemaMigrator
{
    Task MigrateAsync();
}
