using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razer_demo.Startup))]
namespace razer_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
