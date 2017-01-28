using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_Stuff.Startup))]
namespace Lab3_Stuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
