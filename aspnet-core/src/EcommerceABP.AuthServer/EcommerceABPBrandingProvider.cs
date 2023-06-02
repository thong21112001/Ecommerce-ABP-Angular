using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace EcommerceABP;

[Dependency(ReplaceServices = true)]
public class EcommerceABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EcommerceABP";
}
