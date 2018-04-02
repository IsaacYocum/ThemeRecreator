using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThemeCreationPractice.Startup))]
namespace ThemeCreationPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
