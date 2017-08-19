using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models;
using Jaca.Api.Models.Response;
using System;

namespace Jaca.Api.Managers
{
    public class ClientManager : BaseManager, IClientManager
    {
        public BaseResponse<object> CreateClient(Client client)
        {
            var response = new BaseResponse<object>();

            client.Id = Guid.NewGuid().ToString();
            this.ClientRepository.CreateOrUpdate(client);

            response.IsSuccess = true;
            response.StatusCode = System.Net.HttpStatusCode.Created;
            return response;
        }

        public BaseResponse<object> GetClient(string id)
        {
            var response = new BaseResponse<object>();

            var client = this.ClientRepository.GetById(id);

            if (client != null)
            {
                response.IsSuccess = true;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
            }
            
            return response;
        }
    }
}
