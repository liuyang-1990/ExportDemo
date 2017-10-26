using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExportExcelDemo.Startup))]
namespace ExportExcelDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
