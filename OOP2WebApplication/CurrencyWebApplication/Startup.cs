using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurrencyWebApplication.Startup))]
namespace CurrencyWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
