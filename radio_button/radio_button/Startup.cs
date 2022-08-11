using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(radio_button.Startup))]
namespace radio_button
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
