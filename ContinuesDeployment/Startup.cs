using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuesDeployment.Startup))]
namespace ContinuesDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
