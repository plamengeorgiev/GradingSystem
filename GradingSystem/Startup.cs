using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradingSystem.Startup))]
namespace GradingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
