using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_VS_2015_GitDemo.Startup))]
namespace WebApp_VS_2015_GitDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
