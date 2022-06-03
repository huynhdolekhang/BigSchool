using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B3_L4_HuynhDoLeKhang.Startup))]
namespace B3_L4_HuynhDoLeKhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
