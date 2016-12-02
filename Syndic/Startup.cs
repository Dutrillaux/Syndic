using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Syndic.Startup))]
namespace Syndic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
