using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session7MVC.Startup))]
namespace Session7MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
