using Jaca.Api.Models;
using System.Collections.Generic;

namespace Jaca.Api.Repository.Interfaces
{
    public interface ICustomerSaleRepository
    {
        ICollection<CustomerSale> Get(string merchantId);
    }
}
