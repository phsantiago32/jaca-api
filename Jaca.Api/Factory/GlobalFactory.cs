using Jaca.Api.Repository;
using Jaca.Api.Repository.Interfaces;
using Jaca.Api.Utilities;
using Jaca.Api.Utilities.Interfaces;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Serialization.JsonNet;
using Nancy.ModelBinding;
using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Managers;

namespace Jaca.Api.Factory
{
    public class GlobalFactory
    {
        private static TinyIoCContainer Container { get; set; }

        public static TInterface Do<TInterface>() where TInterface : class
        {
            return GlobalFactory.Container.Resolve<TInterface>();
        }

        public static object RegisterDependencies(object container)
        {
            GlobalFactory.Container = (TinyIoCContainer)container;

            // Utilities
            GlobalFactory.Container.Register<IConfigurationUtility, ConfigurationUtility>();
                
            // Serializers
            GlobalFactory.Container.Register<ISerializer, JsonNetSerializer>();
            GlobalFactory.Container.Register<IBodyDeserializer, JsonNetBodyDeserializer>();
            //GlobalFactory.Container.Register<JsonSerializer, CustomJsonSerializer>();

            // Manager
            GlobalFactory.Container.Register<IClientManager, ClientManager>();
            GlobalFactory.Container.Register<IMerchantManager, MerchantManager>();
            GlobalFactory.Container.Register<IPromotionManager, PromotionManager>();

            // Repository
            GlobalFactory.Container.Register<IMerchantRepository, MerchantRepository>();
            GlobalFactory.Container.Register<IClientRepository, ClientRepository>();
            GlobalFactory.Container.Register<IPromotionProgressRepository, PromotionProgressRepository>();
            GlobalFactory.Container.Register<IPromotionRepository, PromotionRepository>();

            return GlobalFactory.Container;
        }
    }
}
