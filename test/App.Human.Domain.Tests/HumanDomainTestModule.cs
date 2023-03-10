using App.Human.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace App.Human;

[DependsOn(
    typeof(HumanEntityFrameworkCoreTestModule)
    )]
public class HumanDomainTestModule : AbpModule
{

}
