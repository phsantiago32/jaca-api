using Jaca.Api.Factory;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Jaca.Api.Bootstraper
{
    public class CustomBootstraper : DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {

            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                                .WithHeader("Access-Control-Allow-Methods", "POST,GET,DELETE")
                                .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");

            });
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container = (TinyIoCContainer)GlobalFactory.RegisterDependencies(container);
            base.ConfigureApplicationContainer(container);
        }
    }
}
