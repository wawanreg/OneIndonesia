using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneIndonesia.Startup))]
namespace OneIndonesia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
