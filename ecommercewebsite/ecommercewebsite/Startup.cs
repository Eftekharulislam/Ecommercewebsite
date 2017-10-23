using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecommercewebsite.Startup))]
namespace ecommercewebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
