using App.Human.Localization;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.UI.Navigation;

namespace App.Human.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class HumanPageModel : AbpPageModel
{
    protected HumanPageModel(IMenuManager menuManager)
    {
        LocalizationResourceType = typeof(HumanResource);
    }
}
