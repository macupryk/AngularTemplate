using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AngularProject.Configuration;
using AngularProject.Web;

namespace AngularProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AngularProjectDbContextFactory : IDesignTimeDbContextFactory<AngularProjectDbContext>
    {
        public AngularProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AngularProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AngularProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AngularProjectConsts.ConnectionStringName));

            return new AngularProjectDbContext(builder.Options);
        }
    }
}
