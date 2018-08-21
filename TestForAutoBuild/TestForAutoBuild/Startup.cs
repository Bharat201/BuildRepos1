using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForAutoBuild.Startup))]
namespace TestForAutoBuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
