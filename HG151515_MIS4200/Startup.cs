using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HG151515_MIS4200.Startup))]
namespace HG151515_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
