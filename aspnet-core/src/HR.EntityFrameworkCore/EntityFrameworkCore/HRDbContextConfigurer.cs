using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HR.EntityFrameworkCore
{
    public static class HRDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HRDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HRDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
