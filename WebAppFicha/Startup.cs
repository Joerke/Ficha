using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppFicha.Startup))]
namespace WebAppFicha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
