using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface IPromotionManager
    {
        BaseResponse<object> GetPromotion(string id);

        BaseResponse<object> CreatePromotion(Promotion promotion);

        BaseResponse<object> GetPromotions(string merchantId);

        BaseResponse<object> DeletePromotion(string id);

        BaseResponse<object> GetPromotionsByCustomer(string customerId);
    }
}
