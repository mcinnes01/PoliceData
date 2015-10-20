using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Police.Web.Startup))]
namespace Police.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
