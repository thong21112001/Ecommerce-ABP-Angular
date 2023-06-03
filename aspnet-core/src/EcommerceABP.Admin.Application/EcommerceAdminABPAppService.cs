using System;
using System.Collections.Generic;
using System.Text;
using EcommerceABP.Localization;
using Volo.Abp.Application.Services;

namespace EcommerceABP.Admin;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAdminABPAppService : ApplicationService
{
    protected EcommerceAdminABPAppService()
    {
        LocalizationResource = typeof(EcommerceABPResource);
    }
}
