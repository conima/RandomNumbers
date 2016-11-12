using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RandomNumbers.Startup))]
namespace RandomNumbers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
