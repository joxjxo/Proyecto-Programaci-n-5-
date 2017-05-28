using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cotizador.UI.Startup))]
namespace Cotizador.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
