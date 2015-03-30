using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HearthStoneInfoTracker.Startup))]
namespace HearthStoneInfoTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
