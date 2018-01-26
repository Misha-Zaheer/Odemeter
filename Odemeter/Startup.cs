using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Odemeter.Startup))]
namespace Odemeter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
