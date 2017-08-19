using Djaka.Api.Managers.Interfaces;
using Djaka.Api.Models;
using Djaka.Api.Models.Response;
using System;

namespace Djaka.Api.Managers
{
    public class MerchantManager : BaseManager, IMerchantManager
    {
        public BaseResponse<object> CreateMerchant(Merchant merchant)
        {
            var response = new BaseResponse<object>();

            merchant.Id = Guid.NewGuid().ToString();
            this.MerchantRepository.CreateOrUpdate(merchant);

            response.StatusCode = System.Net.HttpStatusCode.Created;
            response.IsSuccess = true;
            return response;
        }

        public BaseResponse<object> GetMerchant(string id)
        {
            var response = new BaseResponse<object>();

            var merchant = this.MerchantRepository.GetById(id);

            if (merchant != null)
            {
                response.SuccessBody = merchant;
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.IsSuccess = true;
            }
            else
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
            }

            return response;
        }
    }
}
