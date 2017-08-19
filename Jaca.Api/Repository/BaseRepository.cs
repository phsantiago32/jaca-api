using Jaca.Api.Factory;
using Jaca.Api.Utilities.Interfaces;
using MongoDB.Driver;
using System;

namespace Jaca.Api.Repository
{
    public class BaseRepository<T>
    {
        protected IMongoClient Client { get; set; }

        protected IMongoDatabase Database { get; set; }

        protected IMongoCollection<T> Collection { get; set; }

        protected IConfigurationUtility ConfigurationUtility { get; set; }

        public BaseRepository(string collection)
        {
            this.ConfigurationUtility = GlobalFactory.Do<IConfigurationUtility>();

            var dbName = this.ConfigurationUtility.DatabaseName;

            var server = new MongoServerAddress(
                this.ConfigurationUtility.DatabaseConnectionHost,
                Int32.Parse(this.ConfigurationUtility.DatabaseConnectionPort));

            var credentials = MongoCredential.CreateCredential(dbName,
                this.ConfigurationUtility.DatabaseConnectionUsername,
                this.ConfigurationUtility.DatabaseConnectionPassword);

            var settings = new MongoClientSettings()
            {
                Server = server,
                Credentials = new[] { credentials },
            };

            this.ConfigurationUtility = GlobalFactory.Do<IConfigurationUtility>();
            this.Client = new MongoClient(settings);
            this.Database = this.Client.GetDatabase(dbName);
            this.Collection = this.Database.GetCollection<T>(collection);
        }
    }
}
