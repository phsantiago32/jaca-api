using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface IMerchantManager
    {
        BaseResponse<object> GetMerchant(string id);

        BaseResponse<object> CreateMerchant(Merchant merchant);
    }
}
