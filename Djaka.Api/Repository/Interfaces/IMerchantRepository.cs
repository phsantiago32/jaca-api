using Djaka.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Djaka.Api.Repository.Interfaces
{
    public interface IMerchantRepository
    {
        void CreateOrUpdate(Merchant merchant);

        Merchant GetById(string id);
    }
}
