using Jaca.Api.Models;
using Jaca.Api.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Jaca.Api.Repository
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

        public ICollection<Promotion> GetPromotions(string merchantId)
        {
            return this.Collection.Find(x => x.MerchantId == merchantId).ToList();
        }

        public void DeletePromotion(string id)
        {
            this.Collection.DeleteOne(x => x.Id == id);
        }
    }
}
