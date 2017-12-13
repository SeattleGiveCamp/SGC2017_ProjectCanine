using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectCanine.AdminPortal.Startup))]
namespace ProjectCanine.AdminPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
