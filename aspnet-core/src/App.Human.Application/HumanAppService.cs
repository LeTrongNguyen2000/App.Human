using System;
using System.Collections.Generic;
using System.Text;
using App.Human.Localization;
using Volo.Abp.Application.Services;

namespace App.Human;

/* Inherit your application services from this class.
 */
public abstract class HumanAppService : ApplicationService
{
    protected HumanAppService()
    {
        LocalizationResource = typeof(HumanResource);
    }
}
