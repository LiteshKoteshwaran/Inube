using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonManager.Startup))]
namespace PersonManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
