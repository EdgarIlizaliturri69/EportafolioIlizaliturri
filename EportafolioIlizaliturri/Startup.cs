using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EportafolioIlizaliturri.Startup))]
namespace EportafolioIlizaliturri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
