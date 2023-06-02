using Volo.Abp.Settings;

namespace EcommerceABP.Settings;

public class EcommerceABPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EcommerceABPSettings.MySetting1));
    }
}
