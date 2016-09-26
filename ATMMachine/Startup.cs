using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATMMachine.Startup))]
namespace ATMMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
