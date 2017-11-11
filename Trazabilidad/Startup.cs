using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trazabilidad.Startup))]
namespace Trazabilidad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
