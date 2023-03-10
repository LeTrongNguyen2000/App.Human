using System.Threading.Tasks;

namespace App.Human.Data;

public interface IHumanDbSchemaMigrator
{
    Task MigrateAsync();
}
