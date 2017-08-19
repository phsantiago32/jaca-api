using Jaca.Api.Models;
using Jaca.Api.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace Jaca.Api.Repository
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private const string COLLECTION_NAME = nameof(Client);

        public ClientRepository() : base(COLLECTION_NAME) { }

        public void CreateOrUpdate(Client client)
        {
            this.Collection.ReplaceOne(
                 new BsonDocument("_id", client.Id),
                 client,
                 new UpdateOptions { IsUpsert = true });
        }

        public Client GetById(string id)
        {
            var result = this.Collection.Find(x => x.Id == id).FirstOrDefault();
            return result;
        }
    }
}
