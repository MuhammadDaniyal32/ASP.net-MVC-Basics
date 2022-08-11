using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dropdown_List.Startup))]
namespace dropdown_List
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
