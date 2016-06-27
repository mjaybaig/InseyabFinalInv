using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventoryFinal.Startup))]
namespace InventoryFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
