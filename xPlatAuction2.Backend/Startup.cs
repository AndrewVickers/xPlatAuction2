using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(xPlatAuction2.Backend.Startup))]

namespace xPlatAuction2.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}