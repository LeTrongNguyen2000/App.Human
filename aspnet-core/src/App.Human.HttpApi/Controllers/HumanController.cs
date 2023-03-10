using App.Human.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace App.Human.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HumanController : AbpControllerBase
{
    protected HumanController()
    {
        LocalizationResource = typeof(HumanResource);
    }
}
