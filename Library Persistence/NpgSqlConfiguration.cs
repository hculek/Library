using Npgsql;
using System.Data.Entity;

namespace Library_Persistence
{
    class NpgSqlConfiguration : DbConfiguration
    {
        //https://www.npgsql.org/ef6/index.html#basic-configuration
        public NpgSqlConfiguration()
        {
            var name = "LibraryDBConnection";

            SetProviderFactory(providerInvariantName: name,
                               providerFactory: NpgsqlFactory.Instance);

            SetProviderServices(providerInvariantName: name,
                                provider: NpgsqlServices.Instance);

            SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
        }
    }
}
