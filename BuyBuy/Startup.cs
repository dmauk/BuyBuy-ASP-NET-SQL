using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuyBuy.Startup))]
namespace BuyBuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
