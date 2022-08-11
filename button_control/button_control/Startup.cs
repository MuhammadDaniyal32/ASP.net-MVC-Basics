using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(button_control.Startup))]
namespace button_control
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
