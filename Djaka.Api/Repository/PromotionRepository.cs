using Djaka.Api.Models;
using Djaka.Api.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;

namespace Djaka.Api.Repository
{
    public class PromotionRepository : BaseRepository<Promotion>, IPromotionRepository
    {
        private const string COLLECTION_NAME = nameof(Promotion);

        public PromotionRepository() : base(COLLECTION_NAME) { }

        public void CreateOrUpdate(Promotion merchant)
        {
            this.Collection.ReplaceOne(
                 new BsonDocument("_id", merchant.Id),
                 merchant,
                 new UpdateOptions { IsUpsert = true });
        }

        public Promotion GetById(string id)
        {
            var result = this.Collection.Find(x => x.Id == id).FirstOrDefault();
            return result;
        }
    }
}
