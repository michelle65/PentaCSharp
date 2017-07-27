using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repository_Pattern.Startup))]
namespace Repository_Pattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
