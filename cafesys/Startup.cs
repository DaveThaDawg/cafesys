using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cafesys.Startup))]
namespace cafesys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
