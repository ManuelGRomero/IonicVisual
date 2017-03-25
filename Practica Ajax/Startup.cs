using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica_Ajax.Startup))]
namespace Practica_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
