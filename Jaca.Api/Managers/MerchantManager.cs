using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models;
using Jaca.Api.Models.Response;
using System;

namespace Jaca.Api.Managers
{
    public class MerchantManager : BaseManager, IMerchantManager
    {
        public BaseResponse<object> CreateMerchant(Merchant merchant)
        {
            var response = new BaseResponse<object>();

            merchant.Id = Guid.NewGuid().ToString();
            this.MerchantRepository.CreateOrUpdate(merchant);

            var newUser = new User { Login = merchant.Login, Password = merchant.Password };
            this.UserRepository.CreateOrUpdate(newUser);

            response.SuccessBody = merchant;
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

        public BaseResponse<object> GetAllMerchants()
        {
            var response = new BaseResponse<object>();

            var merchants = this.MerchantRepository.GetAllMerhants();

            response.IsSuccess = true;
            response.SuccessBody = merchants;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
    }
}
