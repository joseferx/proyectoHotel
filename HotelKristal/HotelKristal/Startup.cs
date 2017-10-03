using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelKristal.Startup))]
namespace HotelKristal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
