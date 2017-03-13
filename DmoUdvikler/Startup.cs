using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DmoUdvikler.Startup))]
namespace DmoUdvikler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
