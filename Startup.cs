using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnaStojchevskaINKI_654.Startup))]
namespace AnaStojchevskaINKI_654
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
