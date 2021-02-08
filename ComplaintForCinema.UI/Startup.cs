using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplaintForCinema.Startup))]
namespace ComplaintForCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
