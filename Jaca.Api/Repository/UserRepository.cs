using System;
using Jaca.Api.Models;
using Jaca.Api.Repository.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jaca.Api.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base(COLLECTION_NAME) { }

        private const string COLLECTION_NAME = nameof(User);

        public User GetUser(string userName, string userPassword)
        {
            var result = this.Collection.Find(x => x.Login == userName && x.Password == userPassword).FirstOrDefault();

            return result;
        }

        public void CreateOrUpdate(User user)
        {
            this.Collection.ReplaceOne(
                 new BsonDocument("_id", user.Id),
                 user,
                 new UpdateOptions { IsUpsert = true });
        }

        public User GetLogin(string login)
        {
            return this.Collection.Find(x => x.Login == login).FirstOrDefault();
        }
    }
}
