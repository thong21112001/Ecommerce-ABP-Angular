using Volo.Abp.Modularity;

namespace EcommerceABP;

[DependsOn(
    typeof(EcommerceABPApplicationModule),
    typeof(EcommerceABPDomainTestModule)
    )]
public class EcommerceABPApplicationTestModule : AbpModule
{

}
