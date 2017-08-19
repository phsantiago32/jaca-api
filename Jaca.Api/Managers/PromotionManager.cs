using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models;
using Jaca.Api.Models.Response;
using System;

namespace Jaca.Api.Managers
{
    public class PromotionManager : BaseManager, IPromotionManager
    {

       public BaseResponse<object> CreatePromotion(Promotion promotion)
        {
            var response = new BaseResponse<object>();

            promotion.Id = Guid.NewGuid().ToString();
            this.PromotionRepository.CreateOrUpdate(promotion);

            response.IsSuccess = true;
            response.StatusCode = System.Net.HttpStatusCode.Created;

            return response;
        }

        public BaseResponse<object> GetPromotion(string id)
        {
            var response = new BaseResponse<object>();

            var promotion = this.PromotionRepository.GetById(id);

            if (promotion != null)
            {
                response.SuccessBody = promotion;
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
