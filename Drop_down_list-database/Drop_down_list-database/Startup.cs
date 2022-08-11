using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drop_down_list_database.Startup))]
namespace Drop_down_list_database
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
