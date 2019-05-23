using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(METRONIC8.Startup))]
namespace METRONIC8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
