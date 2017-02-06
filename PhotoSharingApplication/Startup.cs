using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoSharingApplication.Startup))]
namespace PhotoSharingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
