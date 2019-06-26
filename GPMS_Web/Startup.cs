using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPMS_Web.Startup))]
namespace GPMS_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
