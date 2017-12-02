using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(adminlte.Startup))]
namespace adminlte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
