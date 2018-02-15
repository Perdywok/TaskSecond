using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskSecond.Startup))]
namespace TaskSecond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
