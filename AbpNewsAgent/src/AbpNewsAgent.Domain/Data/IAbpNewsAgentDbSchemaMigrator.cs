using System.Threading.Tasks;

namespace AbpNewsAgent.Data
{
    public interface IAbpNewsAgentDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
