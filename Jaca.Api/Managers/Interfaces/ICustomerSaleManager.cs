using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface ICustomerSaleManager
    {
        BaseResponse<object> GetSales(string merchantId);
    }
}
