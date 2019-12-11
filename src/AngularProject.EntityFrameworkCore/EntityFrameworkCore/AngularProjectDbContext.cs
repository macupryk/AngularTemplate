using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AngularProject.Authorization.Roles;
using AngularProject.Authorization.Users;
using AngularProject.MultiTenancy;

namespace AngularProject.EntityFrameworkCore
{
    public class AngularProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AngularProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AngularProjectDbContext(DbContextOptions<AngularProjectDbContext> options)
            : base(options)
        {
        }
    }
}
