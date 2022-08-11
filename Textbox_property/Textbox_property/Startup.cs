using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Textbox_property.Startup))]
namespace Textbox_property
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
