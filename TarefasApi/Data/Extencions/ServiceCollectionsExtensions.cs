using System.Data.SqlClient;
using static TarefasApi.Data.TarefaContext;

namespace TarefasApi.Data.Endpoints.Extencions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersitence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddScoped<GetConnection>(sp =>
            async () =>
            {
                var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            });
            return builder;
        }
    }
}
