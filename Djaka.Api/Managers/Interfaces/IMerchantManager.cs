using Djaka.Api.Models;
using Djaka.Api.Models.Response;

namespace Djaka.Api.Managers.Interfaces
{
    public interface IMerchantManager
    {
        BaseResponse<object> GetMerchant(string id);

        BaseResponse<object> CreateMerchant(Merchant merchant);
    }
}
