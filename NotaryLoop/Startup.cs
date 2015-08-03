using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotaryLoop.Startup))]
namespace NotaryLoop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
