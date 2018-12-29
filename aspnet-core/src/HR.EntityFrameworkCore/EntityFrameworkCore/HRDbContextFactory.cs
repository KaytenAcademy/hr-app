using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HR.Configuration;
using HR.Web;

namespace HR.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HRDbContextFactory : IDesignTimeDbContextFactory<HRDbContext>
    {
        public HRDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HRDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HRDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HRConsts.ConnectionStringName));

            return new HRDbContext(builder.Options);
        }
    }
}
