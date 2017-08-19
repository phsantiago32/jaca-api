using Djaka.Api.Factory;
using Djaka.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Djaka.Api.Managers
{
    public class BaseManager
    {
        private IMerchantRepository _merchantRepository = null;
        public IMerchantRepository MerchantRepository
        {
            get
            {
                if (this._merchantRepository == null)
                {
                    this._merchantRepository = GlobalFactory.Do<IMerchantRepository>();
                }

                return this._merchantRepository;
            }
        }

        private IClientRepository _clientRepository = null;
        public IClientRepository ClientRepository
        {
            get
            {
                if (this._clientRepository == null)
                {
                    this._clientRepository = GlobalFactory.Do<IClientRepository>();
                }

                return this._clientRepository;
            }
        }

        private IPromotionRepository _promotionRepository = null;
        public IPromotionRepository PromotionRepository
        {
            get
            {
                if (this._promotionRepository == null)
                {
                    this._promotionRepository = GlobalFactory.Do<IPromotionRepository>();
                }

                return this._promotionRepository;
            }
        }

        private IPromotionProgressRepository _promotionProgressRepository = null;
        public IPromotionProgressRepository PromotionProgressRepository
        {
            get
            {
                if (this._promotionProgressRepository == null)
                {
                    this._promotionProgressRepository = GlobalFactory.Do<IPromotionProgressRepository>();
                }

                return this._promotionProgressRepository;
            }
        }
    }
}
