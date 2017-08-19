using Djaka.Api.Models;
using Nancy.ModelBinding;

namespace Djaka.Api.Controllers
{
    public class PromotionProgressController : BaseController
    {
        public PromotionProgressController() : base("promotionProgress")
        {
            Get("{id}", args => this.PromotionProgressManager.GetPromotionProgress(args.id));

            Post("", _ => this.PromotionProgressManager.CreatePromotion(this.Bind<PromotionProgress>()));
        }
    }
}
