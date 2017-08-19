using Djaka.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Djaka.Api.Repository.Interfaces
{
    public interface IClientRepository
    {
        void CreateOrUpdate(Client merchant);

        Client GetById(string id);
    }
}
