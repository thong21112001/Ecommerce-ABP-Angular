using System;
using System.Collections.Generic;
using System.Text;
using EcommerceABP.Localization;
using Volo.Abp.Application.Services;

namespace EcommerceABP;

/* Inherit your application services from this class.
 */
public abstract class EcommerceABPAppService : ApplicationService
{
    protected EcommerceABPAppService()
    {
        LocalizationResource = typeof(EcommerceABPResource);
    }
}
