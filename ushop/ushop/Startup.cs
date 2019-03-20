using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ushop.Startup))]
namespace ushop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
