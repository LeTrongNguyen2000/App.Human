using Volo.Abp.UI.Navigation;

namespace App.Human.Web.Pages;

public class IndexModel : HumanPageModel
{
    public IndexModel(IMenuManager menuManager) : base(menuManager)
    {
    }

    public void OnGet()
    {

    }
}
