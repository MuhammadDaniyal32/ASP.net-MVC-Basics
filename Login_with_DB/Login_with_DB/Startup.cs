using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_with_DB.Startup))]
namespace Login_with_DB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
