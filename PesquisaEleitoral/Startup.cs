using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PesquisaEleitoral.Startup))]
namespace PesquisaEleitoral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
