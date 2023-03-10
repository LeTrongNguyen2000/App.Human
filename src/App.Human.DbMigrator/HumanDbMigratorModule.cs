using App.Human.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace App.Human.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HumanEntityFrameworkCoreModule),
    typeof(HumanApplicationContractsModule)
    )]
public class HumanDbMigratorModule : AbpModule
{

}
