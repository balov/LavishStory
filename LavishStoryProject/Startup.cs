using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LavishStoryProject.Startup))]
namespace LavishStoryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
