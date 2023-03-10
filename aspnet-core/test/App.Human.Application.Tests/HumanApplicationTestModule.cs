using Volo.Abp.Modularity;

namespace App.Human;

[DependsOn(
    typeof(HumanApplicationModule),
    typeof(HumanDomainTestModule)
    )]
public class HumanApplicationTestModule : AbpModule
{

}
