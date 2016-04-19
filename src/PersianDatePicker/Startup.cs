using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersianDatePicker.Startup))]
namespace PersianDatePicker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
