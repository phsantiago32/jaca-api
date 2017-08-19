using Djaka.Api.Models;

namespace Djaka.Api.Repository.Interfaces
{
    public interface IPromotionProgressRepository
    {
        void CreateOrUpdate(PromotionProgress merchant);

        PromotionProgress GetById(string id);
    }
}
