using EcommerceABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EcommerceABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceABPController : AbpControllerBase
{
    protected EcommerceABPController()
    {
        LocalizationResource = typeof(EcommerceABPResource);
    }
}
