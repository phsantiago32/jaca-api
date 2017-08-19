using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models;
using Jaca.Api.Models.Response;
using System;

namespace Jaca.Api.Managers
{
    public class PromotionProgressManager : BaseManager, IPromotionProgressManager
    {
        public BaseResponse<object> CreatePromotion(PromotionProgress promotion)
        {
            var response = new BaseResponse<object>();

            promotion.Id = Guid.NewGuid().ToString();

            this.PromotionProgressRepository.CreateOrUpdate(promotion);

            response.IsSuccess = true;
            response.StatusCode = System.Net.HttpStatusCode.Created;

            return response;
        }

        public BaseResponse<object> GetPromotionProgress(string id)
        {
            var response = new BaseResponse<object>();

            var promotionProgress = this.PromotionProgressRepository.GetById(id);

            if (promotionProgress != null)
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
