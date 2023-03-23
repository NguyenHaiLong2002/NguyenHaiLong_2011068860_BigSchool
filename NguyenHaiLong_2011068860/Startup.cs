using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHaiLong_2011068860.Startup))]
namespace NguyenHaiLong_2011068860
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
