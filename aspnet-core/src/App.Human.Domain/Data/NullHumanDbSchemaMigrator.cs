using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace App.Human.Data;

/* This is used if database provider does't define
 * IHumanDbSchemaMigrator implementation.
 */
public class NullHumanDbSchemaMigrator : IHumanDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
