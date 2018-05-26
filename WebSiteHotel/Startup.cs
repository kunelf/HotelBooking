using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteHotel.Startup))]
namespace WebSiteHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
