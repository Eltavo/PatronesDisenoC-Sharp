using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElTavo.RepositoryPattern.ClienteWeb.Startup))]
namespace ElTavo.RepositoryPattern.ClienteWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
