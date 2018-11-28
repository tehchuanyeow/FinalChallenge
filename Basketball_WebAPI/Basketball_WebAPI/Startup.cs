using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Basketball_WebAPI.Startup))]
namespace Basketball_WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
