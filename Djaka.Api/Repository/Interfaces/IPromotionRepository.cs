using Djaka.Api.Models;

namespace Djaka.Api.Repository.Interfaces
{
    public interface IPromotionRepository
    {
        void CreateOrUpdate(Promotion merchant);

        Promotion GetById(string id);
    }
}
