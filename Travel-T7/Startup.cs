using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Travel_T7.Startup))]
namespace Travel_T7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
