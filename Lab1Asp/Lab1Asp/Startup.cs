using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1Asp.Startup))]
namespace Lab1Asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
