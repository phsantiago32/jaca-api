using Djaka.Api.Models;
using Djaka.Api.Models.Response;

namespace Djaka.Api.Managers.Interfaces
{
    public interface IClientManager
    {
        BaseResponse<object> GetClient(string id);

        BaseResponse<object> CreateClient(Client client);
    }
}
