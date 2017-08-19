using Djaka.Api.Utilities.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Djaka.Api.Utilities
{
    public class ConfigurationUtility : IConfigurationUtility
    {
        public ConfigurationUtility()
        {
            Configuration = Startup.Configuration;
        }

        private IConfigurationRoot Configuration { get; set; }

        public string DatabaseConnectionHost => this.Configuration["DatabaseConnection:Host"];

        public string DatabaseConnectionPort => this.Configuration["DatabaseConnection:Port"];

        public string DatabaseConnectionUsername => this.Configuration["DatabaseConnection:Username"];

        public string DatabaseConnectionPassword => this.Configuration["DatabaseConnection:Password"];

        public string DatabaseName => this.Configuration["DatabaseConnection:DbName"];

        public string ConnectionStringMongoDb => this.Configuration["ConnectionString:MongoDb"];
    }
}
