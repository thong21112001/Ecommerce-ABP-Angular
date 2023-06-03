using Volo.Abp.Modularity;

namespace EcommerceABP.Admin;

[DependsOn(
    typeof(EcommerceAdminABPApplicationModule),
    typeof(EcommerceABPDomainTestModule)
    )]
public class EcommerceABPApplicationTestModule : AbpModule
{

}
