using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.EntityFrameworkCore
{
    public static class AngularProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AngularProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AngularProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
