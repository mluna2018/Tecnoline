using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tecnoline.Backend.Startup))]
namespace Tecnoline.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
