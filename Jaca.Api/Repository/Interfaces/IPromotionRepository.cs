using Jaca.Api.Models;
using System.Collections.Generic;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IPromotionRepository
    {
        void CreateOrUpdate(Promotion merchant);

        Promotion GetById(string id);

        ICollection<Promotion> GetPromotions(string merchantId);

        void DeletePromotion(string id);

        //ICollection<Promotion> GetPromotionsByCustomer(string customerId);
    }
}
