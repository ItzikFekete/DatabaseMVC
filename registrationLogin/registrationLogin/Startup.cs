using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(registrationLogin.Startup))]
namespace registrationLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
