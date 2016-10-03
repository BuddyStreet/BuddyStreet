using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuddyStreet.Web.Startup))]
namespace BuddyStreet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
