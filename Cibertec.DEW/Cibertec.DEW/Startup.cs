using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cibertec.DEW.Startup))]
namespace Cibertec.DEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
