using Jaca.Api.Models;
using Jaca.Api.Repository.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Jaca.Api.Repository
{
    public class CustomerSaleRepository : BaseRepository<CustomerSale>, ICustomerSaleRepository
    {
        public CustomerSaleRepository() : base(COLLECTION_NAME) { }

        private const string COLLECTION_NAME = nameof(CustomerSale);

        public ICollection<CustomerSale> Get(string merchantId)
        {
            var result = this.Collection.Find(x => x.MerchantId == merchantId).ToList();

            return result;
        }
    }
}
