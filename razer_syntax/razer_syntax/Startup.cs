using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razer_syntax.Startup))]
namespace razer_syntax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
