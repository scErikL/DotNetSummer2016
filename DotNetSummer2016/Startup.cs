using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetSummer2016.Startup))]
namespace DotNetSummer2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
