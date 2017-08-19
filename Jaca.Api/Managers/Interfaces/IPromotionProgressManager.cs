using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface IPromotionProgressManager
    {
        BaseResponse<object> GetPromotionProgress(string id);

        BaseResponse<object> CreatePromotion(PromotionProgress promotion);
    }
}
