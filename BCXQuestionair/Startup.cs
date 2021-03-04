using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCXQuestionair.Startup))]
namespace BCXQuestionair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
