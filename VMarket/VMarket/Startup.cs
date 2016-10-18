using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMarket.Startup))]
namespace VMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
