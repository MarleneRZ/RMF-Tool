using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phase13.Web.Startup))]
namespace Phase13.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
