using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendGridEasy.Startup))]
namespace SendGridEasy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
