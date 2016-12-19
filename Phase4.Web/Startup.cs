using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phase4.Web.Startup))]
namespace Phase4.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
