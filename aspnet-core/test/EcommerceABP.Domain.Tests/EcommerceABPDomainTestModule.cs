using EcommerceABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EcommerceABP;

[DependsOn(
    typeof(EcommerceABPEntityFrameworkCoreTestModule)
    )]
public class EcommerceABPDomainTestModule : AbpModule
{

}
