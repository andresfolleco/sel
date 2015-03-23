using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEL.Startup))]
namespace SEL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
