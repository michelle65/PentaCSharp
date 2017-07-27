using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales_Database.Startup))]
namespace Sales_Database
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
