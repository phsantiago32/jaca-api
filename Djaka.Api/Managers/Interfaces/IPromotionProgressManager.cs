using Djaka.Api.Models;
using Djaka.Api.Models.Response;

namespace Djaka.Api.Managers.Interfaces
{
    public interface IPromotionProgressManager
    {
        BaseResponse<object> GetPromotionProgress(string id);

        BaseResponse<object> CreatePromotion(PromotionProgress promotion);
    }
}
