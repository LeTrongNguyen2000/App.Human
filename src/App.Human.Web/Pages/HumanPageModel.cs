using App.Human.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace App.Human.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class HumanPageModel : AbpPageModel
{
    protected HumanPageModel()
    {
        LocalizationResourceType = typeof(HumanResource);
    }
}
