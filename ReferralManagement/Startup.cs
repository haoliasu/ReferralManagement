using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReferralManagement.Startup))]
namespace ReferralManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
