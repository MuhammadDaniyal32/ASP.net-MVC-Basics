using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_VIEW.Startup))]
namespace MVC_VIEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
