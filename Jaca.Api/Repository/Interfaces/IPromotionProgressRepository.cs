using Jaca.Api.Models;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IPromotionProgressRepository
    {
        void CreateOrUpdate(PromotionProgress merchant);

        PromotionProgress GetById(string id);
    }
}
