using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonsManagerMVC.Startup))]
namespace PersonsManagerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
