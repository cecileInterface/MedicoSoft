using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMedicoSoft.Startup))]
namespace MVCMedicoSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
