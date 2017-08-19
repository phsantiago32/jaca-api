using Djaka.Api.Factory;
using Nancy;
using Nancy.TinyIoc;

namespace Djaka.Api.Bootstraper
{
    public class CustomBootstraper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container = (TinyIoCContainer)GlobalFactory.RegisterDependencies(container);
            base.ConfigureApplicationContainer(container);
        }
    }
}
