using Jaca.Api.Models;
using Jaca.Api.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jaca.Api.Repository
{
    public class PromotionProgressRepository : BaseRepository<PromotionProgress>, IPromotionProgressRepository
    {
        private const string COLLECTION_NAME = nameof(PromotionProgress);

        public PromotionProgressRepository() : base(COLLECTION_NAME) { }

        public void CreateOrUpdate(PromotionProgress promotionProgress)
        {
            this.Collection.ReplaceOne(
                 new BsonDocument("_id", promotionProgress.Id),
                 promotionProgress,
                 new UpdateOptions { IsUpsert = true });
        }

        public PromotionProgress GetById(string id)
        {
            var result = this.Collection.Find(x => x.Id == id).FirstOrDefault();
            return result;
        }
    }
}
