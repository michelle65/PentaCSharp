using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Homework_2.Startup))]
namespace MVC_Homework_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
