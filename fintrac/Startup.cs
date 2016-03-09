using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fintrac.Startup))]
namespace fintrac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
