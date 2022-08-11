using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Email_sending.Startup))]
namespace Email_sending
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
