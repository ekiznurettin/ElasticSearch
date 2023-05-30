using Elasticsearch.Net;
using Nest;

namespace ElasticSearch.API.Extensions
{
    public static class ElasticSearchExtension
    {
        public static void AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
        {
            var pool = new SingleNodeConnectionPool(new Uri(configuration.GetSection("Elastic")["Url"]!));
            var settings = new ConnectionSettings(pool);
            //settings.BasicAuthentication("username", "password");//appsettings.json daki username ve password ifadeleri gelecek standart olduğu için yazmadık
            var client = new ElasticClient(settings);
            services.AddSingleton(client);
        }

    }
}
