using EcommerceABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EcommerceABP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EcommerceABPEntityFrameworkCoreModule),
    typeof(EcommerceABPApplicationContractsModule)
    )]
public class EcommerceABPDbMigratorModule : AbpModule
{

}
