using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NymityProject.Startup))]
namespace NymityProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
