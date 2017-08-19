using Jaca.Api.Models;
using System.Collections.Generic;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IMerchantRepository
    {
        void CreateOrUpdate(Merchant merchant);

        Merchant GetById(string id);

        List<Merchant> GetAllMerhants();
    }
}
