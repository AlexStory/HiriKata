using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiriKata.Startup))]
namespace HiriKata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
