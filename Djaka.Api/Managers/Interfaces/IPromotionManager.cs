using Djaka.Api.Models;
using Djaka.Api.Models.Response;

namespace Djaka.Api.Managers.Interfaces
{
    public interface IPromotionManager
    {
        BaseResponse<object> GetPromotion(string id);

        BaseResponse<object> CreatePromotion(Promotion promotion);
    }
}
