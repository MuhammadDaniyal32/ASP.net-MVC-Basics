using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DB_first_approch.Startup))]
namespace DB_first_approch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
