using Jaca.Api.Models;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IPromotionRepository
    {
        void CreateOrUpdate(Promotion merchant);

        Promotion GetById(string id);
    }
}
