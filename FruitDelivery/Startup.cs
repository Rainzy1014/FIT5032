using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FruitDelivery.Startup))]
namespace FruitDelivery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
