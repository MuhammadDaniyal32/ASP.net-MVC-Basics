using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_MVC.Startup))]
namespace first_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
