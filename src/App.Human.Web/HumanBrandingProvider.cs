using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace App.Human.Web;

[Dependency(ReplaceServices = true)]
public class HumanBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Human";
}
