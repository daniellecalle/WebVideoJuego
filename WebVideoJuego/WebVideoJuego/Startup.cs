using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebVideoJuego.Startup))]
namespace WebVideoJuego
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
