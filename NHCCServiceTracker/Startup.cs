using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHCCServiceTracker.Startup))]
namespace NHCCServiceTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
