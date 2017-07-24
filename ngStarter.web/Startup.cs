using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ngStarter.web.Startup))]
namespace ngStarter.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
