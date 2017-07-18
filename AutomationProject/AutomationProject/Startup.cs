using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomationProject.Startup))]
namespace AutomationProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
